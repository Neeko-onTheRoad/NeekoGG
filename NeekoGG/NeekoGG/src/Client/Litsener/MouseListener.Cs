using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace nk.Client {
	public class MouseStatus() {
		public bool     LeftClicked       = false;
		public bool     RightClicked      = false;
		public bool     MiddleClicked     = false;
		public bool     LeftRelesed       = false;
		public bool     RightRelesed      = false;
		public bool     MiddleRelesed     = false;
		public bool     LeftClicking      = false;
		public bool     RightClicking     = false;
		public bool     MiddleClicking    = false;
		public Vector2i DragStartPosition = new Vector2i(0, 0);
		public Vector2i Position          = new Vector2i(0, 0);
		public Vector2i PositionDelta     = new Vector2i(0, 0);
		public float    WheelLevel        = 0f;
	}
	
	public static class MouseListener {
	
		private static float deltaTime;

		private static MouseStatus status = new MouseStatus();
		public  static MouseStatus Status { get { return status; } private set { status = value; } }

		public static void Initialize(ref RenderWindow _window) {
			_window.MouseButtonPressed += (object? _sender, MouseButtonEventArgs _event) => {
				Status.DragStartPosition = new Vector2i(_event.X, _event.Y);

				if(_event.Button == Mouse.Button.Left) {
					Status.LeftClicked  = true;
					Status.LeftClicking = true;
				}

				if(_event.Button == Mouse.Button.Right) {
					Status.RightClicked  = true;
					Status.RightClicking = true;
				}

				if(_event.Button == Mouse.Button.Middle) {
					Status.MiddleClicked  = true;
					Status.MiddleClicking = true;
				}
			};

			_window.MouseButtonReleased += (object? _sender, MouseButtonEventArgs _event) => {
				if(_event.Button == Mouse.Button.Left) {
					Status.LeftRelesed  = true;
					Status.LeftClicking = false;
				}

				if(_event.Button == Mouse.Button.Right) {
					Status.RightRelesed  = true;
					Status.RightClicking = false;
				}

				if(_event.Button == Mouse.Button.Middle) {
					Status.MiddleRelesed  = true;
					Status.MiddleClicking = false;
				}
			};

			_window.MouseMoved += (object? _sender, MouseMoveEventArgs _event) => {
				Vector2i position = new Vector2i(_event.X, _event.Y);

				Status.PositionDelta = Status.Position - position;
				Status.Position = position;
			};

			_window.MouseWheelScrolled += (object? _sender, MouseWheelScrollEventArgs _event) => {
				Status.WheelLevel = _event.Delta;

				
				Status.Position = new Vector2i(_event.X, _event.Y); 
			};
		}

		public static void Update(float _deltaTime) {
			deltaTime = _deltaTime;

			Status.LeftClicked   = false;
			Status.RightClicked  = false;
			Status.MiddleClicked = false;

			Status.LeftRelesed   = false;
			Status.RightRelesed  = false;
			Status.MiddleRelesed = false;

			Status.WheelLevel    = 0f;
		}
	}
}