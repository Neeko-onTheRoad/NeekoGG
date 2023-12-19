using SFML.Graphics;

namespace nk.Client {
	public abstract class StatusBase() {
		
	}

	public abstract class ListenerBase {
		
		public abstract StatusBase Status { get; }

		public abstract void Initialize(RenderWindow _window);
		public abstract void Update();

	}
}
