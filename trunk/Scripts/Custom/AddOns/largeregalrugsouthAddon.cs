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
	public class largeregalrugsouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new largeregalrugsouthAddonDeed();
			}
		}

		[ Constructable ]
		public largeregalrugsouthAddon()
		{
			AddonComponent ac = null;
			ac = new AddonComponent( 2762 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, 2, -1, 0 );
			ac = new AddonComponent( 2765 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 2765 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 2765 );
			AddComponent( ac, -2, 2, 0 );
			ac = new AddonComponent( 2758 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 2, 1, 0 );
			ac = new AddonComponent( 2758 );
			AddComponent( ac, -1, 2, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 0, 2, 0 );
			ac = new AddonComponent( 2758 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 2758 );
			AddComponent( ac, 1, 2, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 2, 0, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 2, 2, 0 );
			ac = new AddonComponent( 2766 );
			AddComponent( ac, 3, -1, 0 );
			ac = new AddonComponent( 2760 );
			AddComponent( ac, 3, 1, 0 );
			ac = new AddonComponent( 2758 );
			AddComponent( ac, 3, 0, 0 );
			ac = new AddonComponent( 2758 );
			AddComponent( ac, 3, 2, 0 );

		}

		public largeregalrugsouthAddon( Serial serial ) : base( serial )
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

	public class largeregalrugsouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new largeregalrugsouthAddon();
			}
		}

		[Constructable]
		public largeregalrugsouthAddonDeed()
		{
			Name = "large regal rug south";
		}

		public largeregalrugsouthAddonDeed( Serial serial ) : base( serial )
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