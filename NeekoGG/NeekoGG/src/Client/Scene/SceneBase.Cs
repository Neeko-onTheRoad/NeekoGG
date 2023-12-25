namespace nk {
	public abstract class SceneBase {
		protected abstract class Sprites : SpritesBase;

		protected abstract void Draw();
		protected abstract void Update();
		protected abstract void Initialize();
	}
}