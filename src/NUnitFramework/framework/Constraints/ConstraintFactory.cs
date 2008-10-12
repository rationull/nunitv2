// ****************************************************************
// Copyright 2008, Charlie Poole
// This is free software licensed under the NUnit license. You may
// obtain a copy of the license at http://nunit.org
// ****************************************************************

// ****************************************************************
//              Generated by the NUnit Syntax Generator
//
// Command Line: GenSyntax.exe SyntaxElements.txt
// 
//                  DO NOT MODIFY THIS FILE DIRECTLY
// ****************************************************************

using System;
using System.Collections;

namespace NUnit.Framework.Constraints
{
    /// <summary>
    /// Helper class with properties and methods that supply
    /// a number of constraints used in Asserts.
    /// </summary>
    public class ConstraintFactory
    {
        /// <summary>
        /// Returns a ConstraintExpression that negates any
        /// following constraint.
        /// </summary>
        public ConstraintExpression Not
        {
            get { return Is.Not; }
        }
        
        /// <summary>
        /// Returns a ConstraintExpression that negates any
        /// following constraint.
        /// </summary>
        public ConstraintExpression No
        {
            get { return Has.No; }
        }
        
        /// <summary>
        /// Returns a ConstraintExpression, which will apply
        /// the following constraint to all members of a collection,
        /// succeeding if all of them succeed.
        /// </summary>
        public ConstraintExpression All
        {
            get { return Is.All; }
        }
        
        /// <summary>
        /// Returns a ConstraintExpression, which will apply
        /// the following constraint to all members of a collection,
        /// succeeding if at least one of them succeeds.
        /// </summary>
        public ConstraintExpression Some
        {
            get { return Has.Some; }
        }
        
        /// <summary>
        /// Returns a ConstraintExpression, which will apply
        /// the following constraint to all members of a collection,
        /// succeeding if all of them fail.
        /// </summary>
        public ConstraintExpression None
        {
            get { return Has.None; }
        }
        
        /// <summary>
        /// Returns a new PropertyConstraintExpression, which will either
        /// test for the existence of the named property on the object
        /// being tested or apply any following constraint to that property.
        /// </summary>
        public ResolvableConstraintExpression Property(string name)
        {
            return Has.Property(name);
        }
        
        /// <summary>
        /// Returns a new ConstraintExpression, which will apply the following
        /// constraint to the Length property of the object being tested.
        /// </summary>
        public ResolvableConstraintExpression Length
        {
            get { return Has.Length; }
        }
        
        /// <summary>
        /// Returns a new ConstraintExpression, which will apply the following
        /// constraint to the Count property of the object being tested.
        /// </summary>
        public ResolvableConstraintExpression Count
        {
            get { return Has.Count; }
        }
        
        /// <summary>
        /// Returns a new ConstraintExpression, which will apply the following
        /// constraint to the Message property of the object being tested.
        /// </summary>
        public ResolvableConstraintExpression Message
        {
            get { return Has.Message; }
        }
        
        /// <summary>
        /// Returns a new AttributeConstraint checking for the
        /// presence of a particular attribute on an object.
        /// </summary>
        public ResolvableConstraintExpression Attribute(Type expectedType)
        {
            return Has.Attribute(expectedType);
        }
        
#if NET_2_0
        /// <summary>
        /// Returns a new AttributeConstraint checking for the
        /// presence of a particular attribute on an object.
        /// </summary>
        public ResolvableConstraintExpression Attribute<T>()
        {
            return Attribute(typeof(T));
        }
#endif
        
        /// <summary>
        /// Returns a constraint that tests for null
        /// </summary>
        public NullConstraint Null
        {
            get { return Is.Null; }
        }
        
        /// <summary>
        /// Returns a constraint that tests for True
        /// </summary>
        public TrueConstraint True
        {
            get { return Is.True; }
        }
        
        /// <summary>
        /// Returns a constraint that tests for False
        /// </summary>
        public FalseConstraint False
        {
            get { return Is.False; }
        }
        
        /// <summary>
        /// Returns a constraint that tests for NaN
        /// </summary>
        public NaNConstraint NaN
        {
            get { return Is.NaN; }
        }
        
        /// <summary>
        /// Returns a constraint that tests for empty
        /// </summary>
        public EmptyConstraint Empty
        {
            get { return Is.Empty; }
        }
        
        /// <summary>
        /// Returns a constraint that tests whether a collection 
        /// contains all unique items.
        /// </summary>
        public UniqueItemsConstraint Unique
        {
            get { return Is.Unique; }
        }
        
        /// <summary>
        /// Returns a constraint that tests whether an object graph is serializable in binary format.
        /// </summary>
        public BinarySerializableConstraint BinarySerializable
        {
            get { return Is.BinarySerializable; }
        }
        
        /// <summary>
        /// Returns a constraint that tests whether an object graph is serializable in xml format.
        /// </summary>
        public XmlSerializableConstraint XmlSerializable
        {
            get { return Is.XmlSerializable; }
        }
        
        /// <summary>
        /// Returns a constraint that tests two items for equality
        /// </summary>
        public EqualConstraint EqualTo(object expected)
        {
            return Is.EqualTo(expected);
        }
        
        /// <summary>
        /// Returns a constraint that tests that two references are the same object
        /// </summary>
        public SameAsConstraint SameAs(object expected)
        {
            return Is.SameAs(expected);
        }
        
        /// <summary>
        /// Returns a constraint that tests whether the
        /// actual value is greater than the suppled argument
        /// </summary>
        public GreaterThanConstraint GreaterThan(IComparable expected)
        {
            return Is.GreaterThan(expected);
        }
        
        /// <summary>
        /// Returns a constraint that tests whether the
        /// actual value is greater than the suppled argument
        /// </summary>
        public GreaterThanOrEqualConstraint GreaterThanOrEqualTo(IComparable expected)
        {
            return Is.GreaterThanOrEqualTo(expected);
        }
        
        /// <summary>
        /// Returns a constraint that tests whether the
        /// actual value is greater than the suppled argument
        /// </summary>
        public GreaterThanOrEqualConstraint AtLeast(IComparable expected)
        {
            return Is.AtLeast(expected);
        }
        
        /// <summary>
        /// Returns a constraint that tests whether the
        /// actual value is greater than the suppled argument
        /// </summary>
        public LessThanConstraint LessThan(IComparable expected)
        {
            return Is.LessThan(expected);
        }
        
        /// <summary>
        /// Returns a constraint that tests whether the
        /// actual value is greater than the suppled argument
        /// </summary>
        public LessThanOrEqualConstraint LessThanOrEqualTo(IComparable expected)
        {
            return Is.LessThanOrEqualTo(expected);
        }
        
        /// <summary>
        /// Returns a constraint that tests whether the
        /// actual value is greater than the suppled argument
        /// </summary>
        public LessThanOrEqualConstraint AtMost(IComparable expected)
        {
            return Is.AtMost(expected);
        }
        
        /// <summary>
        /// Returns a constraint that tests whether the actual
        /// value is of the exact type supplied as an argument.
        /// </summary>
        public ExactTypeConstraint TypeOf(Type expectedType)
        {
            return Is.TypeOf(expectedType);
        }
        
#if NET_2_0
        /// <summary>
        /// Returns a constraint that tests whether the actual
        /// value is of the exact type supplied as an argument.
        /// </summary>
        public ExactTypeConstraint TypeOf<T>()
        {
            return TypeOf(typeof(T));
        }
#endif
        
        /// <summary>
        /// Returns a constraint that tests whether the actual value
        /// is of the type supplied as an argument or a derived type.
        /// </summary>
        [Obsolete("Use InstanceOf(expectedType)")]
        public InstanceOfTypeConstraint InstanceOfType(Type expectedType)
        {
            return InstanceOf(expectedType);
        }
        
#if NET_2_0
        /// <summary>
        /// Returns a constraint that tests whether the actual value
        /// is of the type supplied as an argument or a derived type.
        /// </summary>
        [Obsolete("Use InstanceOf<T>()")]
        public InstanceOfTypeConstraint InstanceOfType<T>()
        {
            return InstanceOf<T>();
        }
#endif
        
        /// <summary>
        /// Returns a constraint that tests whether the actual value
        /// is of the type supplied as an argument or a derived type.
        /// </summary>
        public InstanceOfTypeConstraint InstanceOf(Type expectedType)
        {
            return Is.InstanceOf(expectedType);
        }
        
#if NET_2_0
        /// <summary>
        /// Returns a constraint that tests whether the actual value
        /// is of the type supplied as an argument or a derived type.
        /// </summary>
        public InstanceOfTypeConstraint InstanceOf<T>()
        {
            return InstanceOf(typeof(T));
        }
#endif
        
        /// <summary>
        /// Returns a constraint that tests whether the actual value
        /// is assignable from the type supplied as an argument.
        /// </summary>
        public AssignableFromConstraint AssignableFrom(Type expectedType)
        {
            return Is.AssignableFrom(expectedType);
        }
        
#if NET_2_0
        /// <summary>
        /// Returns a constraint that tests whether the actual value
        /// is assignable from the type supplied as an argument.
        /// </summary>
        public AssignableFromConstraint AssignableFrom<T>()
        {
            return AssignableFrom(typeof(T));
        }
#endif
        
        /// <summary>
        /// Returns a constraint that tests whether the actual value
        /// is assignable from the type supplied as an argument.
        /// </summary>
        public AssignableToConstraint AssignableTo(Type expectedType)
        {
            return Is.AssignableTo(expectedType);
        }
        
#if NET_2_0
        /// <summary>
        /// Returns a constraint that tests whether the actual value
        /// is assignable from the type supplied as an argument.
        /// </summary>
        public AssignableToConstraint AssignableTo<T>()
        {
            return AssignableTo(typeof(T));
        }
#endif
        
        /// <summary>
        /// Returns a constraint that tests whether the actual value
        /// is a collection containing the same elements as the 
        /// collection supplied as an argument.
        /// </summary>
        public CollectionEquivalentConstraint EquivalentTo(IEnumerable expected)
        {
            return Is.EquivalentTo(expected);
        }
        
        /// <summary>
        /// Returns a constraint that tests whether the actual value
        /// is a subset of the collection supplied as an argument.
        /// </summary>
        public CollectionSubsetConstraint SubsetOf(IEnumerable expected)
        {
            return Is.SubsetOf(expected);
        }
        
        /// <summary>
        /// Returns a constraint that tests whether a collection is ordered
        /// </summary>
        public CollectionOrderedConstraint Ordered()
        {
            return Is.Ordered();
        }
        
        /// <summary>
        /// Returns a constraint that tests whether a collection is ordered
        /// </summary>
        public CollectionOrderedConstraint Ordered(IComparer comparer)
        {
            return Is.Ordered(comparer);
        }
        
        /// <summary>
        /// Returns a constraint that tests whether a collection is ordered
        /// </summary>
        public CollectionOrderedConstraint OrderedBy(string propertyName)
        {
            return Is.OrderedBy(propertyName);
        }
        
        /// <summary>
        /// Returns a constraint that tests whether a collection is ordered
        /// </summary>
        public CollectionOrderedConstraint OrderedBy(string propertyName, IComparer comparer)
        {
            return Is.OrderedBy(propertyName, comparer);
        }
        
        /// <summary>
        /// Returns a new CollectionContainsConstraint checking for the
        /// presence of a particular object in the collection.
        /// </summary>
        public CollectionContainsConstraint Contains(object expected)
        {
            return new CollectionContainsConstraint(expected);
        }
        
        /// <summary>
        /// Returns a new CollectionContainsConstraint checking for the
        /// presence of a particular object in the collection.
        /// </summary>
        public CollectionContainsConstraint Member(object expected)
        {
            return new CollectionContainsConstraint(expected);
        }
        
        /// <summary>
        /// Returns a new ContainsConstraint. This constraint
        /// will, in turn, make use of the appropriate second-level
        /// constraint, depending on the type of the actual argument. 
        /// This overload is only used if the item sought is a string,
        /// since any other type implies that we are looking for a 
        //// collection member.
        /// </summary>
        public ContainsConstraint Contains(string expected)
        {
            return new ContainsConstraint(expected);
        }
        
        /// <summary>
        /// Returns a constraint that succeeds if the actual
        /// value contains the substring supplied as an argument.
        /// </summary>
        public SubstringConstraint ContainsSubstring(string expected)
        {
            return Text.Contains(expected);
        }
        
        /// <summary>
        /// Returns a constraint that fails if the actual
        /// value contains the substring supplied as an argument.
        /// </summary>
        public SubstringConstraint DoesNotContain(string expected)
        {
            return Text.DoesNotContain(expected);
        }
        
        /// <summary>
        /// Returns a constraint that succeeds if the actual
        /// value starts with the substring supplied as an argument.
        /// </summary>
        public StartsWithConstraint StartsWith(string expected)
        {
            return Text.StartsWith(expected);
        }
        
        /// <summary>
        /// Returns a constraint that fails if the actual
        /// value starts with the substring supplied as an argument.
        /// </summary>
        public StartsWithConstraint DoesNotStartWith(string expected)
        {
            return Text.DoesNotStartWith(expected);
        }
        
        /// <summary>
        /// Returns a constraint that succeeds if the actual
        /// value ends with the substring supplied as an argument.
        /// </summary>
        public EndsWithConstraint EndsWith(string expected)
        {
            return Text.EndsWith(expected);
        }
        
        /// <summary>
        /// Returns a constraint that fails if the actual
        /// value ends with the substring supplied as an argument.
        /// </summary>
        public EndsWithConstraint DoesNotEndWith(string expected)
        {
            return Text.DoesNotEndWith(expected);
        }
        
        /// <summary>
        /// Returns a constraint that succeeds if the actual
        /// value matches the pattern supplied as an argument.
        /// </summary>
        public RegexConstraint Matches(string pattern)
        {
            return Text.Matches(pattern);
        }
        
        /// <summary>
        /// Returns a constraint that fails if the actual
        /// value matches the pattern supplied as an argument.
        /// </summary>
        public RegexConstraint DoesNotMatch(string pattern)
        {
            return Text.DoesNotMatch(pattern);
        }
        
        /// <summary>
        /// Returns a constraint that tests whether the path provided 
        /// is the same as an expected path after canonicalization.
        /// </summary>
        public SamePathConstraint SamePath(string expected)
        {
            return Is.SamePath(expected);
        }
        
        /// <summary>
        /// Returns a constraint that tests whether the path provided 
        /// is the same path or under an expected path after canonicalization.
        /// </summary>
        public SamePathOrUnderConstraint SamePathOrUnder(string expected)
        {
            return Is.SamePathOrUnder(expected);
        }
        
        /// <summary>
        /// Returns a constraint that tests whether the actual value falls 
        /// within a specified range.
        /// </summary>
        public RangeConstraint InRange(IComparable from, IComparable to)
        {
            return Is.InRange(from, to);
        }
        
    }
}
