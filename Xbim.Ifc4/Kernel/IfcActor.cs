// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using Xbim.Ifc4.ActorResource;
using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcActor
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcActor : IIfcObject
	{
		IfcActorSelect @TheActor { get; }
		IEnumerable<IIfcRelAssignsToActor> @IsActingUpon {  get; }
		
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IFCACTOR", 392)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcActor : IfcObject, IInstantiableEntity, IIfcActor, IEqualityComparer<@IfcActor>, IEquatable<@IfcActor>
	{
		#region IIfcActor explicit implementation
		IfcActorSelect IIfcActor.TheActor { get { return @TheActor; } }	
	
	 
		IEnumerable<IIfcRelAssignsToActor> IIfcActor.IsActingUpon {  get { return @IsActingUpon; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcActor(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcActorSelect _theActor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcActorSelect @TheActor 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _theActor;
				((IPersistEntity)this).Activate(false);
				return _theActor;
			} 
			set
			{
				SetValue( v =>  _theActor = v, _theActor, value,  "TheActor");
			} 
		}	
		#endregion


		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IEnumerable<IfcRelAssignsToActor> @IsActingUpon 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssignsToActor>(e => (e.RelatingActor as IfcActor) == this);
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_theActor = (IfcActorSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcActor other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcActor
            var root = (@IfcActor)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcActor left, @IfcActor right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcActor left, @IfcActor right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcActor x, @IfcActor y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcActor obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}