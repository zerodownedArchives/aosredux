/////////////////////////////////////////////////
//
// Automatically generated by the
// AddonGenerator script by Arya
//
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class mediumbluecarpetAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new mediumbluecarpetAddonDeed();
			}
		}

		[ Constructable ]
		public mediumbluecarpetAddon()
		{
			AddComponent( new AddonComponent( 2757 ), 2, -2, 0 );
			AddComponent( new AddonComponent( 2754 ), 2, 2, 0 );
			AddComponent( new AddonComponent( 2808 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 2750 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 2809 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 2753 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 2753 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 2808 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 2755 ), -2, -2, 0 );
			AddComponent( new AddonComponent( 2806 ), -2, -1, 0 );
			AddComponent( new AddonComponent( 2809 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 2750 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 2753 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 2807 ), -1, -2, 0 );
			AddComponent( new AddonComponent( 2753 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 2806 ), -2, 1, 0 );
			AddComponent( new AddonComponent( 2806 ), -2, 0, 0 );
			AddComponent( new AddonComponent( 2809 ), -1, 2, 0 );
			AddComponent( new AddonComponent( 2756 ), -2, 2, 0 );
			AddComponent( new AddonComponent( 2807 ), 1, -2, 0 );
			AddComponent( new AddonComponent( 2750 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 2750 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 2750 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 2807 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 2808 ), 2, -1, 0 );
			AddonComponent ac = null;
			ac = new AddonComponent( 2755 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 2806 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 2806 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 2806 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 2807 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 2753 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2750 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2753 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2807 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 2807 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 2750 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2750 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 2750 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2750 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2753 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 2753 );
			AddComponent( ac, 1, 1, 0 );

		}

		public mediumbluecarpetAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class mediumbluecarpetAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new mediumbluecarpetAddon();
			}
		}

		[Constructable]
		public mediumbluecarpetAddonDeed()
		{
			Name = "medium blue carpet";
		}

		public mediumbluecarpetAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}