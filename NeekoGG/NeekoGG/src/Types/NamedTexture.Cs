#if false
using SFML.Graphics;

namespace nk {
	public struct NamedTexture {
		public Texture Texture;
		public string  Name;

		public NamedTexture() {
			Texture = new Texture(0, 0);
			Name    = "N/A";
		}

		public NamedTexture(Texture _texture) {
			Texture = _texture;
			Name    = "N/A";
		}

		public NamedTexture(
			Texture _texture,
			string  _name
		) {
			Texture = _texture;
			Name    = _name;
		}

		public override string ToString() {
			return $"[NamedTexture] {Name}";
		}
	}
}
#endif