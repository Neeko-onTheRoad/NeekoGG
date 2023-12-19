using SFML.Graphics;
using SFML.Window;
using SFML.System;

namespace nk.Client {
	public abstract class WindowBase {
		
		public string WindowTitle     = "Neeko.GG";
		public int    TargetFPS       = 144;
		public float  TimeUntilUpdate = 1f/144;

		protected static Vector2u WindowSize{ get; private set; }

		private RenderWindow window;
		public  RenderWindow Window     { get { return window; } protected set { window = value; } }
		public  ClientTime   ClientTime { get; protected set; }

		protected MouseListener    MouseListener    = new MouseListener();
		protected KeyboardListener KeyboardListener = new KeyboardListener();

		protected List<ListenerBase> Listeners = new List<ListenerBase>();

		protected WindowBase(string _title) {
			window          = new RenderWindow(new VideoMode(0, 0), "");
			WindowTitle     = _title;
			TargetFPS       = 144;
			TimeUntilUpdate = 1f/TargetFPS;
			ClientTime      = new ClientTime();

			Listeners.Add(MouseListener);
			Listeners.Add(KeyboardListener);
		}

		public void Run() {
			Initialize();

			foreach (var i in Listeners) i.Initialize(window);

			SetWindowSize(1f);

			float totalTimeBeforeUpdate = 0f;
			float previousTimeElapsed   = 0f;
			float deltaTime             = 0f;
			float totalTimeElapsed      = 0f;

			Clock clock = new Clock();

			while(Window.IsOpen) {
				foreach (var i in Listeners) i.Update();

				Window.DispatchEvents();

				if (MouseListener.Status.LeftClicked == true) Console.WriteLine(MouseListener.Status.LeftClicked);

				totalTimeElapsed    = clock.ElapsedTime.AsSeconds();
				deltaTime           = totalTimeElapsed - previousTimeElapsed;
				previousTimeElapsed = totalTimeElapsed;

				totalTimeBeforeUpdate += deltaTime;

				if (totalTimeBeforeUpdate >= TimeUntilUpdate) {
					ClientTime.Update(totalTimeBeforeUpdate, clock.ElapsedTime.AsSeconds());
					totalTimeBeforeUpdate = 0f;

					Update(ClientTime);

					Window.Clear();
					Draw(ClientTime);
					Window.Display();
				}
				
			}			
		}

		public abstract void Initialize();
		public abstract void Update(ClientTime _gameTime);
		public abstract void Draw(ClientTime _gameTime);

		private void WindowClosed(object? sender, EventArgs e) {
			Window.Close();
		}

		public void SetWindowSize(float _size) {
			WindowSize = new Vector2u(
				(uint)(VideoMode.DesktopMode.Height * (4f / 6f) * (16f / 9f) * _size),
				(uint)(VideoMode.DesktopMode.Height * (4f / 6f) * _size)
			);
			Window.Close();
			Window = new RenderWindow(new VideoMode(WindowSize.X, WindowSize.Y), WindowTitle, Styles.None);
			Window.Closed += WindowClosed;
		}
	}
}
