using SFML.Graphics;
using SFML.System;

namespace nk {
	public class RoundedRectangle : Drawable {

		public enum Corners {
			TOP_LEFT     = 0,
			TOP_RIGHT    = 1,
			BOTTOM_LEFT  = 3,
			BOTTOM_RIGHT = 4
		}

		private Vector2f size;
		private Vector2f position;
		private float    roundness;

		private Dictionary<Corners, bool>         roundedCorners;
		private Dictionary<Corners, CircleShape?> cornerBuffers;
		private RectangleShape[]?                 rectangleBuffer;

		public RoundedRectangle() {
			size      = new(1, 1);
			position  = new(0, 0);
			roundness = 1f;

			roundedCorners = new() {
				{ Corners.TOP_LEFT,     true },
				{ Corners.TOP_RIGHT,    true },
				{ Corners.BOTTOM_LEFT , true },
				{ Corners.BOTTOM_RIGHT, true }
			};

			cornerBuffers = new() {
				{ Corners.TOP_LEFT,     null },
				{ Corners.TOP_RIGHT,    null },
				{ Corners.BOTTOM_LEFT , null },
				{ Corners.BOTTOM_RIGHT, null }
			};
		}

		void Drawable.Draw(RenderTarget _target, RenderStates _states) {
            foreach (var i in cornerBuffers) {
				_target.Draw(i.Value);                
            }
        }
	
	}
}
