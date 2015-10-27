// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.TopologyResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcEdgeLoop
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcEdgeLoop : IIfcLoop
	{
		IEnumerable<IIfcOrientedEdge> @EdgeList { get; }
		
	}
}

namespace Xbim.Ifc4.TopologyResource
{
	[ExpressType("IFCEDGELOOP", 597)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcEdgeLoop : IfcLoop, IInstantiableEntity, IIfcEdgeLoop, IEqualityComparer<@IfcEdgeLoop>, IEquatable<@IfcEdgeLoop>
	{
		#region IIfcEdgeLoop explicit implementation
		IEnumerable<IIfcOrientedEdge> IIfcEdgeLoop.EdgeList { get { return @EdgeList; } }	
	
	 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcEdgeLoop(IModel model) : base(model) 		{ 
			Model = model; 
			_edgeList = new ItemSet<IfcOrientedEdge>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcOrientedEdge> _edgeList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcOrientedEdge> @EdgeList 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _edgeList;
				((IPersistEntity)this).Activate(false);
				return _edgeList;
			} 
		}	
		#endregion




		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					if (_edgeList == null) _edgeList = new ItemSet<IfcOrientedEdge>( this );
					_edgeList.InternalAdd((IfcOrientedEdge)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*IsClosed:	IsClosed : (EdgeList[1].EdgeStart) :=: (EdgeList[Ne].EdgeEnd);*/
		/*IsContinuous:	IsContinuous : IfcLoopHeadToTail(SELF);*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcEdgeLoop other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcEdgeLoop
            var root = (@IfcEdgeLoop)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcEdgeLoop left, @IfcEdgeLoop right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcEdgeLoop left, @IfcEdgeLoop right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcEdgeLoop x, @IfcEdgeLoop y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcEdgeLoop obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}