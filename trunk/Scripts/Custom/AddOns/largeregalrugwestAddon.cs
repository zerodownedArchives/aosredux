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
	public class largeregalrugwestAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new largeregalrugwestAddonDeed();
			}
		}

		[ Constructable ]
		public largeregalrugwestAddon()
		{
			AddComponent( new AddonComponent( 2768 ), 1, 3, 0 );
			AddComponent( new AddonComponent( 2759 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 2768 ), -1, 3, 0 );
			AddComponent( new AddonComponent( 2759 ), -1, 2, 0 );
			AddComponent( new AddonComponent( 2760 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 2759 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 2760 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 2760 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 2766 ), -1, -3, 0 );
			AddComponent( new AddonComponent( 2766 ), 0, -3, 0 );
			AddComponent( new AddonComponent( 2766 ), 1, -3, 0 );
			AddComponent( new AddonComponent( 2764 ), 2, -3, 0 );
			AddComponent( new AddonComponent( 2760 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 2760 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 2760 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 2759 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 2762 ), -2, -3, 0 );
			AddComponent( new AddonComponent( 2765 ), -2, -2, 0 );
			AddComponent( new AddonComponent( 2765 ), -2, -1, 0 );
			AddComponent( new AddonComponent( 2765 ), -2, 0, 0 );
			AddComponent( new AddonComponent( 2765 ), -2, 1, 0 );
			AddComponent( new AddonComponent( 2765 ), -2, 2, 0 );
			AddComponent( new AddonComponent( 2763 ), -2, 3, 0 );
			AddComponent( new AddonComponent( 2767 ), 2, -2, 0 );
			AddComponent( new AddonComponent( 2759 ), 1, -2, 0 );
			AddComponent( new AddonComponent( 2767 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 2767 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 2767 ), 2, 2, 0 );
			AddComponent( new AddonComponent( 2761 ), 2, 3, 0 );
			AddComponent( new AddonComponent( 2760 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 2768 ), 0, 3, 0 );
			AddComponent( new AddonComponent( 2760 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 2767 ), 2, -1, 0 );
			AddComponent( new AddonComponent( 2760 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 2759 ), -1, -2, 0 );
			AddonComponent ac = null;
			ac = new AddonComponent( 2762 );
			AddComponent( ac, -2, -3, 0 );
			ac = new AddonComponent( 2765 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 2765 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 2765 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 2765 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 2765 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, -1, -3, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, 0, -3, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, 1, -3, 0 );
			ac = new AddonComponent( 2759 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 2759 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 2759 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 2759 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 2759 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 2759 );
			AddComponent( ac, 1, 2, 0 );

		}

		public largeregalrugwestAddon( Serial serial ) : base( serial )
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

	public class largeregalrugwestAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new largeregalrugwestAddon();
			}
		}

		[Constructable]
		public largeregalrugwestAddonDeed()
		{
			Name = "large regal rug west";
		}

		public largeregalrugwestAddonDeed( Serial serial ) : base( serial )
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