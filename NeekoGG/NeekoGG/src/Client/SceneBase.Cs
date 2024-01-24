using nk.Client;
using SFML.System;

namespace nk {
	public abstract class SceneBase {
		public Vector2u SceneSize   { get; protected set; }
		public Vector2f SceneOffset { get; protected set; }

		protected SpriteUnion SpriteUnion { get; set; } = [];

		public SceneBase(Vector2u _size, Vector2f _offset) {
			SceneSize   = _size;
			SceneOffset = _offset;
		}

		public abstract void Initialize();
		public abstract void Update(ClientTime _clientTime);
		public abstract void Draw(ClientTime _clientTime);
	}
}