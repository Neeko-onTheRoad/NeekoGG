namespace nk {

	public class AttackDamage                 : ItemStatBass<int>;           // 공격력
	public class AbilityPower                 : ItemStatBass<int>;           // 주문력
	public class Armor                        : ItemStatBass<int>;           // 방어력
	public class LethalityAndArmorPenetration : ItemStatBass<IntAndPercent>; // 물리/방어구 관통력
	public class MagicResistance              : ItemStatBass<int>;           // 마법 저항력
	public class MagicPenetration             : ItemStatBass<IntAndPercent>; // 마법 관통력
	public class Health                       : ItemStatBass<int>;           // 체력
	public class Mana                         : ItemStatBass<int>;           // 마나
	public class AttackSpeed                  : ItemStatBass<Percent>;       // 공격 속도
	public class CriticalStrikeChance         : ItemStatBass<Percent>;       // 치명타 확률
	public class AbilityHaste                 : ItemStatBass<int>;           // 스킬 가속
	public class MovementSpeed                : ItemStatBass<IntAndPercent>; // 이동 속도
	public class BaseHealthRegeneration       : ItemStatBass<Percent>;       // 기본 체력 재생
	public class BaseManaRegeneration         : ItemStatBass<Percent>;       // 기본 마나 재생
	public class Lifesteal                    : ItemStatBass<Percent>;       // 생명력 흡수
	public class OmmiVamp                     : ItemStatBass<Percent>;       // 모든 피해 흡혈
	public class HealAndShieldPower           : ItemStatBass<Percent>;       // 체력 회복 및 보호막
	public class GoldPerSecond                : ItemStatBass<int>;           // 초당 골드

	public struct ItemStat {
		public AttackDamage?                 AttackDamage;
		public AbilityPower?                 AbilityPower;
		public Armor?                        Armor;
		public LethalityAndArmorPenetration? LethalityAndArmorPenetration;
		public MagicResistance?              MagicResistance;
		public MagicPenetration?             MagicPenetration;
		public Health?                       Health;
		public Mana?                         Mana;
		public AttackSpeed?                  AttackSpeed;
		public CriticalStrikeChance?         CriticalStrike;
		public AbilityHaste?                 AbilityHaste;
		public MovementSpeed?                MovementSpeed;
		public BaseHealthRegeneration?       BaseHealthRegeneration;
		public BaseManaRegeneration?         BaseManaRegeneration;
		public Lifesteal?                    Lifesteal;
		public OmmiVamp?                     OmmiVamp;
		public HealAndShieldPower?           HealAndShieldPower;
		public GoldPerSecond?                GoldPerSecond;

		public ItemStat() { }

		public ItemStat(
			in AttackDamage?                 _attackDamage                 = null,
			in AbilityPower?                 _abilityPower                 = null,
			in Armor?                        _armor                        = null,
			in LethalityAndArmorPenetration? _lethalityAndArmorPenetration = null,
			in MagicResistance?              _magicResistance              = null,
			in MagicPenetration?             _magicPenetration             = null,
			in Health?                       _health                       = null,
			in Mana?                         _mana                         = null,
			in AttackSpeed?                  _attackSpeed                  = null,
			in CriticalStrikeChance?         _criticalStrikeChance         = null,
			in AbilityHaste?                 _abilityHaste                 = null,
			in MovementSpeed?                _movementSpeed                = null,
			in BaseHealthRegeneration?       _baseHealthRegeneration       = null,
			in BaseManaRegeneration?         _baseManaRegeneration         = null,
			in Lifesteal?                    _lifesteal                    = null,
			in OmmiVamp?                     _omniVamp                     = null,
			in HealAndShieldPower?           _healAndShieldPower           = null,
			in GoldPerSecond?                _goldPerSecond                = null
		) {
			AttackDamage				 = _attackDamage;
			AbilityPower				 = _abilityPower;
			Armor						 = _armor;
			LethalityAndArmorPenetration = _lethalityAndArmorPenetration;
			MagicResistance				 = _magicResistance;
			MagicPenetration			 = _magicPenetration;
			Health						 = _health;
			Mana						 = _mana;
			AttackSpeed					 = _attackSpeed;
			CriticalStrike				 = _criticalStrikeChance;
			AbilityHaste				 = _abilityHaste;
			MovementSpeed				 = _movementSpeed;
			BaseHealthRegeneration		 = _baseHealthRegeneration;
			BaseManaRegeneration		 = _baseManaRegeneration;
			Lifesteal					 = _lifesteal;
			OmmiVamp					 = _omniVamp;
			HealAndShieldPower			 = _healAndShieldPower;
			GoldPerSecond				 = _goldPerSecond;
		}
	}

}
