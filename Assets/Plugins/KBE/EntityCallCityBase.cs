/*
	Generated by KBEngine!
	Please do not modify this file!
	
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	// defined in */scripts/entity_defs/City.def
	public class EntityBaseEntityCall_CityBase : EntityCall
	{

		public EntityBaseEntityCall_CityBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_BASE;
		}

		public void reqSellGoodsList()
		{
			Bundle pBundle = newCall("reqSellGoodsList", 0);
			if(pBundle == null)
				return;

			sendCall(null);
		}

	}

	public class EntityCellEntityCall_CityBase : EntityCall
	{

		public EntityCellEntityCall_CityBase(Int32 eid, string ename) : base(eid, ename)
		{
			type = ENTITYCALL_TYPE.ENTITYCALL_TYPE_CELL;
		}

	}
	}