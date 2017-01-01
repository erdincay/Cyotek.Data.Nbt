﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using NUnit.Framework;

namespace Cyotek.Data.Nbt.Tests
{
  partial class TagLongTests
  {
    [Test]
    public void Constructor_sets_name()
    {
      // arrange
      TagLong target;
      string expected;
      string actual;

      expected = "Alphatag";

      // act
      target = new TagLong(expected);

      // assert
      actual = target.Name;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Constructor_sets_default_name()
    {
      // arrange
      TagLong target;
      string expected;
      string actual;

      expected = string.Empty;

      // act
      target = new TagLong();

      // assert
      actual = target.Name;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Constructor_sets_default_value()
    {
      // arrange
      TagLong target;
      long expected;
      long actual;

      expected = 0;

      // act
      target = new TagLong();

      // assert
      actual = target.Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Constructor_sets_value()
    {
      // arrange
      TagLong target;
      long expected;
      long actual;

      expected = 4611686018427387903;

      // act
      target = new TagLong(string.Empty, expected);

      // assert
      actual = target.Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Constructor_sets_value_without_name()
    {
      // arrange
      TagLong target;
      long expected;
      long actual;

      expected = 4611686018427387903;

      // act
      target = new TagLong(expected);

      // assert
      actual = target.Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void SetValue_updates_value()
    {
      // arrange
      Tag target;
      long expected;
      long actual;

      target = new TagLong();

      expected = 4611686018427387903;

      // act
      target.SetValue(expected);

      // assert
      actual = ((TagLong)target).Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetValue_retrieves_value()
    {
      // arrange
      Tag target;
      long expected;
      object actual;

      expected = 4611686018427387903;

      target = TagFactory.CreateTag(expected);

      // act
      actual = target.GetValue();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Equals_returns_true_for_matching_tag()
    {
      // arrange
      TagLong target;
      TagLong other;
      bool actual;

      target = new TagLong("alpha", 4611686018427387903);
      other = new TagLong("alpha", 4611686018427387903);

      // act
      actual = target.Equals(other);

      // assert
      Assert.IsTrue(actual);
    }

    [Test]
    public void Equals_returns_false_with_different_name()
    {
      // arrange
      TagLong target;
      TagLong other;
      bool actual;

      target = new TagLong("Alpha", 4611686018427387903);
      other = new TagLong("Beta", 4611686018427387903);

      // act
      actual = target.Equals(other);

      // assert
      Assert.IsFalse(actual);
    }

    [Test]
    public void Equals_returns_false_with_different_value()
    {
      // arrange
      TagLong target;
      TagLong other;
      bool actual;

      target = new TagLong(string.Empty, 4611686018427387903);
      other = new TagLong(string.Empty, 2305843009213693951);

      // act
      actual = target.Equals(other);

      // assert
      Assert.IsFalse(actual);
    }

    [Test]
    public void Type_returns_correct_value()
    {
      // arrange
      TagLong target;
      TagType expected;
      TagType actual;

      target = new TagLong();

      expected = TagType.Long;

      // act
      actual = target.Type;

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetHashCode_returns_same_value_for_matching_tags()
    {
      // arrange
      TagLong target;
      int actual;
      int expected;

      target = new TagLong("beta", 4611686018427387903);

      expected = new TagLong("beta", 4611686018427387903).GetHashCode();

      // act
      actual = target.GetHashCode();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetHashCode_returns_different_values_with_different_name()
    {
      // arrange
      TagLong target;
      int actual;
      int notExpected;

      target = new TagLong("Alpha", 4611686018427387903);

      notExpected = new TagLong("Beta", 4611686018427387903).GetHashCode();

      // act
      actual = target.GetHashCode();

      // assert
      Assert.AreNotEqual(notExpected, actual);
    }

    [Test]
    public void GetHashCode_returns_different_values_with_different_value()
    {
      // arrange
      TagLong target;
      int actual;
      int notExpected;

      target = new TagLong(string.Empty, 4611686018427387903);

      notExpected = new TagLong(string.Empty, 2305843009213693951).GetHashCode();

      // act
      actual = target.GetHashCode();

      // assert
      Assert.AreNotEqual(notExpected, actual);
    }

    [Test]
    public void Value_can_be_set()
    {
      // arrange
      TagLong target;
      long expected;
      long actual;

      expected = 4611686018427387903;

      target = new TagLong();

      // act
      target.Value = expected;

      // assert
      actual = target.Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ToValueString_returns_string_version_of_value()
    {
      // arrange
      TagLong target;
      string expected;
      string actual;

      expected = "4611686018427387903";

      target = new TagLong(string.Empty, 4611686018427387903);

      // act
      actual = target.ToValueString();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ToString_returns_string_version_of_tag()
    {
      // arrange
      TagLong target;
      string expected;
      string actual;

      expected = "[Long: gamma=4611686018427387903]";

      target = new TagLong("gamma", 4611686018427387903);

      // act
      actual = target.ToString();

      // assert
      Assert.AreEqual(expected, actual);
    }
  }
}

