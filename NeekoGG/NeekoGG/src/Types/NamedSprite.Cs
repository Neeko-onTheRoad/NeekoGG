using SFML.Graphics;

namespace nk {
	public struct NamedSprite {
		public Sprite Sprite;
		public string Name;

		public NamedSprite() {
			Sprite = new Sprite(new Texture(0, 0));
			Name   = "N/A";
		}

		public NamedSprite(
			Sprite _sprite,
			string _name = "N/A"
		) {
			Sprite = _sprite;
			Name   = _name;
		}

		public NamedSprite(
			Texture _texture,
			string  _name = "N/A"
		) {
			Sprite = new Sprite(_texture);
			Name   = _name;
		}

		public NamedSprite(NamedTexture _tna) {
			Sprite = new Sprite(_tna.Texture);
			Name   = _tna.Name;
		}

		public override string ToString() {
			return $"[NamedSprite] {Name}";
		}
	}
}
