using SFML.Graphics;

namespace nk.Client {
	public class KeyboardStatus : StatusBase {
		
	}

	public class KeyboardListener : ListenerBase {

		private KeyboardStatus status = new KeyboardStatus();
		public override KeyboardStatus Status { get { return status; } }

		public override void Initialize(RenderWindow _window) {
			
		}

		public override void Update() {
			
		}
	}
}
