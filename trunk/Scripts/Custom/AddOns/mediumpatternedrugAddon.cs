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
	public class mediumpatternedrugAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new mediumpatternedrugAddonDeed();
			}
		}

		[ Constructable ]
		public mediumpatternedrugAddon()
		{
			AddComponent( new AddonComponent( 2795 ), 1, 1, 0 );
			AddComponent( new AddonComponent( 2792 ), -1, -2, 0 );
			AddComponent( new AddonComponent( 2793 ), 2, 1, 0 );
			AddComponent( new AddonComponent( 2795 ), -1, -1, 0 );
			AddComponent( new AddonComponent( 2794 ), 1, 2, 0 );
			AddComponent( new AddonComponent( 2791 ), -2, -1, 0 );
			AddComponent( new AddonComponent( 2792 ), 0, -2, 0 );
			AddComponent( new AddonComponent( 2795 ), 0, -1, 0 );
			AddComponent( new AddonComponent( 2788 ), -2, -2, 0 );
			AddComponent( new AddonComponent( 2791 ), -2, 0, 0 );
			AddComponent( new AddonComponent( 2795 ), -1, 0, 0 );
			AddComponent( new AddonComponent( 2795 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 2793 ), 2, -1, 0 );
			AddComponent( new AddonComponent( 2790 ), 2, -2, 0 );
			AddComponent( new AddonComponent( 2793 ), 2, 0, 0 );
			AddComponent( new AddonComponent( 2795 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 2795 ), 1, -1, 0 );
			AddComponent( new AddonComponent( 2794 ), -1, 2, 0 );
			AddComponent( new AddonComponent( 2795 ), -1, 1, 0 );
			AddComponent( new AddonComponent( 2791 ), -2, 1, 0 );
			AddComponent( new AddonComponent( 2795 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 2794 ), 0, 2, 0 );
			AddComponent( new AddonComponent( 2792 ), 1, -2, 0 );
			AddComponent( new AddonComponent( 2789 ), -2, 2, 0 );
			AddComponent( new AddonComponent( 2787 ), 2, 2, 0 );
			AddonComponent ac = null;
			ac = new AddonComponent( 2788 );
			AddComponent( ac, -2, -2, 0 );
			ac = new AddonComponent( 2791 );
			AddComponent( ac, -2, -1, 0 );
			ac = new AddonComponent( 2791 );
			AddComponent( ac, -2, 0, 0 );
			ac = new AddonComponent( 2792 );
			AddComponent( ac, -1, -2, 0 );
			ac = new AddonComponent( 2792 );
			AddComponent( ac, 0, -2, 0 );
			ac = new AddonComponent( 2795 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 2795 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 2795 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 2795 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 2791 );
			AddComponent( ac, -2, 1, 0 );
			ac = new AddonComponent( 2795 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 2795 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 2792 );
			AddComponent( ac, 1, -2, 0 );
			ac = new AddonComponent( 2795 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 2795 );
			AddComponent( ac, 1, 0, 0 );
			ac = new AddonComponent( 2795 );
			AddComponent( ac, 1, 1, 0 );

		}

		public mediumpatternedrugAddon( Serial serial ) : base( serial )
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

	public class mediumpatternedrugAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new mediumpatternedrugAddon();
			}
		}

		[Constructable]
		public mediumpatternedrugAddonDeed()
		{
			Name = "medium patterned rug";
		}

		public mediumpatternedrugAddonDeed( Serial serial ) : base( serial )
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