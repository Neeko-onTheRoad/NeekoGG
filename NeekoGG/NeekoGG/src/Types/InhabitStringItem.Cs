using SFML.Graphics;

namespace nk {
	public class InhabitStringItem {
		public object Value {
			get { return Value; }
			set {
				try {
					if (value == null) {
						Value = "";
						return;
					}

					else if (value is string)      Value = value;
					else if (value is NamedSprite) Value = value;
					else if (value is Color)       Value = value;

					else throw new Exception();
				}
				catch(Exception _ex) {
					Console.WriteLine($"Wrong value on InhabitStringItems: {value?.GetType()} {_ex.StackTrace}");
				}
			}
		}

		public InhabitStringItem() {
			Value = "";
		}
		
		public InhabitStringItem(object _value) {
			Value = _value;
		}

		public string ToElementString() {
			return $"{Value?.GetType().Name}: {Value?.ToString()}";
		}

		public override string ToString() {
			if (Value is string) return (string)Value;

			if (Value is NamedSprite) {
				NamedSprite result = (NamedSprite)Value;
				return $"[file: {result.Name}]";
			}

			else return "";
		}
	}
}
