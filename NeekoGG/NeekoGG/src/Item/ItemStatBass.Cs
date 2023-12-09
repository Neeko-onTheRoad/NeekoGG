using SFML.Graphics;

namespace nk {
	
	/// <summary>
	///		<br>아이템의 공격력, 방어력과 같은 스탯을 만들기 위한 베이스 클래스</br>
	///		<br> </br>
	///		<br>포함 정적 Read only 인스턴스 : </br>
	///		<br><see cref="name"/></br>
	///		<br><see cref="isValuePercent"/></br>
	///		<br><see cref="color"/></br>
	///		<br><see cref="icon"/></br>
	///		<br> </br>
	///		<br>포함 public 인스턴스 : </br>
	///		<br><see cref="value"/></br>
	/// </summary>

	public class ItemStatBass<ValueType> where ValueType : new() {
		
		private static string        name  = "N/A";
		private static Color         color = new Color(0xFFFFFF);
		private static NamedSprite icon  = new NamedSprite();

		private ValueType value = new ValueType();

		public ItemStatBass() {}
		
		public static void init(string _name, Color _color, in NamedSprite _icon) {
			name  = _name;
			color = _color;
			icon  = _icon;
		}

		public string        Name  { get { return name;  } }
		public Color         Color { get { return color; } }
		public NamedSprite Icon  { get { return icon;  } }

		public ValueType Value {
			get { return value; }
			set { this.value = value; }
		}

		public override string? ToString() {
			return value?.ToString();
		}
	}
}