using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace nk.Client {
	public class MouseStatus() : StatusBase {
		public bool     LeftClicked    = false;
		public bool     RightClicked   = false;
		public bool     MiddleClicked  = false;
		public bool     LeftRelesed    = false;
		public bool     RightRelesed   = false;
		public bool     MiddleRelesed  = false;
		public bool     LeftClicking   = false;
		public bool     RightClicking  = false;
		public bool     MiddleClicking = false;
		public Vector2i Position       = new Vector2i(0, 0);
		public Vector2i DeltaPosition  = new Vector2i(0, 0);
	}
	
	public class MouseListener : ListenerBase {

		private MouseStatus status = new MouseStatus();
		public override MouseStatus Status { get { return status; } }

		public override void Initialize(RenderWindow _window) {
			_window.MouseButtonPressed += (object? _sender, MouseButtonEventArgs _event) => {
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

				Status.DeltaPosition -= position;
				Status.Position       = position;
			};
		}

		public override void Update() {
			Status.LeftClicked   = false;
			Status.RightClicked  = false;
			Status.MiddleClicked = false;

			Status.LeftRelesed   = false;
			Status.RightRelesed  = false;
			Status.MiddleRelesed = false;
		}
	}
}