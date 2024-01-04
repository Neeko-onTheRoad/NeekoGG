using SFML.System;

namespace nk.Client {
	public class EmptyScene : SceneBase {

		public EmptyScene(Vector2u s, Vector2f o) : base(s, o) {}

		
		
		public override void Initialize() {
		}

		public override void Update(ClientTime _clientTime) {
		}

		public override void Draw(ClientTime _clientTime) {
		}
	}
}