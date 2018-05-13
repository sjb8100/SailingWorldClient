/*
	Generated by KBEngine!
	Please do not modify this file!
	Please inherit this module, such as: (class City : CityBase)
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/City.def
	// Please inherit and implement "class City : CityBase"
	public abstract class CityBase : Entity
	{
		public EntityBaseEntityCall_CityBase baseEntityCall = null;
		public EntityCellEntityCall_CityBase cellEntityCall = null;

		public Int64 BusinessDvelopment = 0;
		public virtual void onBusinessDvelopmentChanged(Int64 oldValue) {}
		public Byte CityCountry = 0;
		public virtual void onCityCountryChanged(Byte oldValue) {}
		public UInt32 CityID = 0;
		public virtual void onCityIDChanged(UInt32 oldValue) {}
		public string CityName = "";
		public virtual void onCityNameChanged(string oldValue) {}
		public Byte CityType = 0;
		public virtual void onCityTypeChanged(Byte oldValue) {}
		public Int64 MilitaryDvelopment = 0;
		public virtual void onMilitaryDvelopmentChanged(Int64 oldValue) {}
		public CITY_SELL_GOODS_LIST SellGoodsList = new CITY_SELL_GOODS_LIST();
		public virtual void onSellGoodsListChanged(CITY_SELL_GOODS_LIST oldValue) {}


		public CityBase()
		{
		}

		public override void onGetBase()
		{
			baseEntityCall = new EntityBaseEntityCall_CityBase(id, className);
		}

		public override void onGetCell()
		{
			cellEntityCall = new EntityCellEntityCall_CityBase(id, className);
		}

		public override void onLoseCell()
		{
			cellEntityCall = null;
		}

		public override EntityCall getBaseEntityCall()
		{
			return baseEntityCall;
		}

		public override EntityCall getCellEntityCall()
		{
			return cellEntityCall;
		}

		public override void onRemoteMethodCall(MemoryStream stream)
		{
			ScriptModule sm = EntityDef.moduledefs["City"];

			UInt16 methodUtype = 0;
			UInt16 componentPropertyUType = 0;

			if(sm.useMethodDescrAlias)
			{
				componentPropertyUType = stream.readUint8();
				methodUtype = stream.readUint8();
			}
			else
			{
				componentPropertyUType = stream.readUint16();
				methodUtype = stream.readUint16();
			}

			Method method = null;

			if(componentPropertyUType == 0)
			{
				method = sm.idmethods[methodUtype];
			}
			else
			{
				Property pComponentPropertyDescription = sm.idpropertys[componentPropertyUType];
				switch(pComponentPropertyDescription.properUtype)
				{
					default:
						break;
				}

				return;
			}

			switch(method.methodUtype)
			{
				default:
					break;
			};
		}

		public override void onUpdatePropertys(MemoryStream stream)
		{
			ScriptModule sm = EntityDef.moduledefs["City"];
			Dictionary<UInt16, Property> pdatas = sm.idpropertys;

			while(stream.length() > 0)
			{
				UInt16 _t_utype = 0;
				UInt16 _t_child_utype = 0;

				{
					if(sm.usePropertyDescrAlias)
					{
						_t_utype = stream.readUint8();
						_t_child_utype = stream.readUint8();
					}
					else
					{
						_t_utype = stream.readUint16();
						_t_child_utype = stream.readUint16();
					}
				}

				Property prop = null;

				if(_t_utype == 0)
				{
					prop = pdatas[_t_child_utype];
				}
				else
				{
					Property pComponentPropertyDescription = pdatas[_t_utype];
					switch(pComponentPropertyDescription.properUtype)
					{
						default:
							break;
					}

					return;
				}

				switch(prop.properUtype)
				{
					case 7:
						Int64 oldval_BusinessDvelopment = BusinessDvelopment;
						BusinessDvelopment = stream.readInt64();

						if(prop.isBase())
						{
							if(inited)
								onBusinessDvelopmentChanged(oldval_BusinessDvelopment);
						}
						else
						{
							if(inWorld)
								onBusinessDvelopmentChanged(oldval_BusinessDvelopment);
						}

						break;
					case 6:
						Byte oldval_CityCountry = CityCountry;
						CityCountry = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onCityCountryChanged(oldval_CityCountry);
						}
						else
						{
							if(inWorld)
								onCityCountryChanged(oldval_CityCountry);
						}

						break;
					case 3:
						UInt32 oldval_CityID = CityID;
						CityID = stream.readUint32();

						if(prop.isBase())
						{
							if(inited)
								onCityIDChanged(oldval_CityID);
						}
						else
						{
							if(inWorld)
								onCityIDChanged(oldval_CityID);
						}

						break;
					case 4:
						string oldval_CityName = CityName;
						CityName = stream.readUnicode();

						if(prop.isBase())
						{
							if(inited)
								onCityNameChanged(oldval_CityName);
						}
						else
						{
							if(inWorld)
								onCityNameChanged(oldval_CityName);
						}

						break;
					case 5:
						Byte oldval_CityType = CityType;
						CityType = stream.readUint8();

						if(prop.isBase())
						{
							if(inited)
								onCityTypeChanged(oldval_CityType);
						}
						else
						{
							if(inWorld)
								onCityTypeChanged(oldval_CityType);
						}

						break;
					case 8:
						Int64 oldval_MilitaryDvelopment = MilitaryDvelopment;
						MilitaryDvelopment = stream.readInt64();

						if(prop.isBase())
						{
							if(inited)
								onMilitaryDvelopmentChanged(oldval_MilitaryDvelopment);
						}
						else
						{
							if(inWorld)
								onMilitaryDvelopmentChanged(oldval_MilitaryDvelopment);
						}

						break;
					case 9:
						CITY_SELL_GOODS_LIST oldval_SellGoodsList = SellGoodsList;
						SellGoodsList = ((DATATYPE_CITY_SELL_GOODS_LIST)EntityDef.id2datatypes[23]).createFromStreamEx(stream);

						if(prop.isBase())
						{
							if(inited)
								onSellGoodsListChanged(oldval_SellGoodsList);
						}
						else
						{
							if(inWorld)
								onSellGoodsListChanged(oldval_SellGoodsList);
						}

						break;
					case 40001:
						Vector3 oldval_direction = direction;
						direction = stream.readVector3();

						if(prop.isBase())
						{
							if(inited)
								onDirectionChanged(oldval_direction);
						}
						else
						{
							if(inWorld)
								onDirectionChanged(oldval_direction);
						}

						break;
					case 40000:
						Vector3 oldval_position = position;
						position = stream.readVector3();

						if(prop.isBase())
						{
							if(inited)
								onPositionChanged(oldval_position);
						}
						else
						{
							if(inWorld)
								onPositionChanged(oldval_position);
						}

						break;
					case 40002:
						stream.readUint32();
						break;
					default:
						break;
				};
			}
		}

		public override void callPropertysSetMethods()
		{
			ScriptModule sm = EntityDef.moduledefs["City"];
			Dictionary<UInt16, Property> pdatas = sm.idpropertys;

			Int64 oldval_BusinessDvelopment = BusinessDvelopment;
			Property prop_BusinessDvelopment = pdatas[4];
			if(prop_BusinessDvelopment.isBase())
			{
				if(inited && !inWorld)
					onBusinessDvelopmentChanged(oldval_BusinessDvelopment);
			}
			else
			{
				if(inWorld)
				{
					if(prop_BusinessDvelopment.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onBusinessDvelopmentChanged(oldval_BusinessDvelopment);
					}
				}
			}

			Byte oldval_CityCountry = CityCountry;
			Property prop_CityCountry = pdatas[5];
			if(prop_CityCountry.isBase())
			{
				if(inited && !inWorld)
					onCityCountryChanged(oldval_CityCountry);
			}
			else
			{
				if(inWorld)
				{
					if(prop_CityCountry.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onCityCountryChanged(oldval_CityCountry);
					}
				}
			}

			UInt32 oldval_CityID = CityID;
			Property prop_CityID = pdatas[6];
			if(prop_CityID.isBase())
			{
				if(inited && !inWorld)
					onCityIDChanged(oldval_CityID);
			}
			else
			{
				if(inWorld)
				{
					if(prop_CityID.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onCityIDChanged(oldval_CityID);
					}
				}
			}

			string oldval_CityName = CityName;
			Property prop_CityName = pdatas[7];
			if(prop_CityName.isBase())
			{
				if(inited && !inWorld)
					onCityNameChanged(oldval_CityName);
			}
			else
			{
				if(inWorld)
				{
					if(prop_CityName.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onCityNameChanged(oldval_CityName);
					}
				}
			}

			Byte oldval_CityType = CityType;
			Property prop_CityType = pdatas[8];
			if(prop_CityType.isBase())
			{
				if(inited && !inWorld)
					onCityTypeChanged(oldval_CityType);
			}
			else
			{
				if(inWorld)
				{
					if(prop_CityType.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onCityTypeChanged(oldval_CityType);
					}
				}
			}

			Int64 oldval_MilitaryDvelopment = MilitaryDvelopment;
			Property prop_MilitaryDvelopment = pdatas[9];
			if(prop_MilitaryDvelopment.isBase())
			{
				if(inited && !inWorld)
					onMilitaryDvelopmentChanged(oldval_MilitaryDvelopment);
			}
			else
			{
				if(inWorld)
				{
					if(prop_MilitaryDvelopment.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onMilitaryDvelopmentChanged(oldval_MilitaryDvelopment);
					}
				}
			}

			CITY_SELL_GOODS_LIST oldval_SellGoodsList = SellGoodsList;
			Property prop_SellGoodsList = pdatas[10];
			if(prop_SellGoodsList.isBase())
			{
				if(inited && !inWorld)
					onSellGoodsListChanged(oldval_SellGoodsList);
			}
			else
			{
				if(inWorld)
				{
					if(prop_SellGoodsList.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onSellGoodsListChanged(oldval_SellGoodsList);
					}
				}
			}

			Vector3 oldval_direction = direction;
			Property prop_direction = pdatas[2];
			if(prop_direction.isBase())
			{
				if(inited && !inWorld)
					onDirectionChanged(oldval_direction);
			}
			else
			{
				if(inWorld)
				{
					if(prop_direction.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onDirectionChanged(oldval_direction);
					}
				}
			}

			Vector3 oldval_position = position;
			Property prop_position = pdatas[1];
			if(prop_position.isBase())
			{
				if(inited && !inWorld)
					onPositionChanged(oldval_position);
			}
			else
			{
				if(inWorld)
				{
					if(prop_position.isOwnerOnly() && !isPlayer())
					{
					}
					else
					{
						onPositionChanged(oldval_position);
					}
				}
			}

		}
	}
}