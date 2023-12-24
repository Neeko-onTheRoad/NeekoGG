using SFML.Graphics;

namespace nk {

	public class ItemStatBase<ValueType> where ValueType : new() {
		
		public readonly static string Name  = "N/A";
		public readonly static Color  Color = new Color(0xFFFFFF);
		public readonly static Sprite Icon  = new Sprite();

		static ItemStatBase() {
			// override this function
		}		

		public ValueType Value { get; set; } = new ValueType();

		public override string? ToString() {
			return Value?.ToString();
		}
	}
}