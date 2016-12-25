﻿

 //------------------------------------------------------------------------------
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
  [TestFixture]
  public partial class TagStringTests : TestBase
  {
    [Test]
    public void Constructor_sets_name()
    {
      // arrange
      TagString target;
      string expected;
      string actual;

      expected = "Alphatag";

      // act
      target = new TagString(expected);

      // assert
      actual = target.Name;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Constructor_sets_default_name()
    {
      // arrange
      TagString target;
      string expected;
      string actual;

      expected = string.Empty;

      // act
      target = new TagString();

      // assert
      actual = target.Name;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Constructor_sets_default_value()
    {
      // arrange
      TagString target;
      string expected;
      string actual;

      expected = string.Empty;

      // act
      target = new TagString();

      // assert
      actual = target.Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Constructor_sets_value()
    {
      // arrange
      TagString target;
      string expected;
      string actual;

      expected = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";

      // act
      target = new TagString(string.Empty, expected);

      // assert
      actual = target.Value;
      Assert.AreEqual(expected, actual);
    }


    [Test]
    public void SetValue_updates_value()
    {
      // arrange
      Tag target;
      string expected;
      string actual;

      target = new TagString();

      expected = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";

      // act
      target.SetValue(expected);

      // assert
      actual = ((TagString)target).Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetValue_retrieves_value()
    {
      // arrange
      Tag target;
      string expected;
      object actual;

      expected = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";

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
      TagString target;
      TagString other;
      bool actual;

      target = new TagString("alpha", "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!");
      other = new TagString("alpha", "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!");

      // act
      actual = target.Equals(other);

      // assert
      Assert.IsTrue(actual);
    }

    [Test]
    public void Equals_returns_false_with_different_name()
    {
      // arrange
      TagString target;
      TagString other;
      bool actual;

      target = new TagString("Alpha", "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!");
      other = new TagString("Beta", "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!");

      // act
      actual = target.Equals(other);

      // assert
      Assert.IsFalse(actual);
    }

    [Test]
    public void Equals_returns_false_with_different_value()
    {
      // arrange
      TagString target;
      TagString other;
      bool actual;

      target = new TagString(string.Empty, "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!");
      other = new TagString(string.Empty, "DIFFERENT");

      // act
      actual = target.Equals(other);

      // assert
      Assert.IsFalse(actual);
    }

    [Test]
    public void Type_returns_correct_value()
    {
      // arrange
      TagString target;
      TagType expected;
      TagType actual;

      target = new TagString();

      expected = TagType.String;

      // act
      actual = target.Type;

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetHashCode_returns_same_value_for_matching_tags()
    {
      // arrange
      TagString target;
      int actual;
      int expected;

      target = new TagString("beta", "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!");

      expected = new TagString("beta", "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!").GetHashCode();

      // act
      actual = target.GetHashCode();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetHashCode_returns_different_values_with_different_name()
    {
      // arrange
      TagString target;
      int actual;
      int notExpected;

      target = new TagString("Alpha", "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!");

      notExpected = new TagString("Beta", "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!").GetHashCode();

      // act
      actual = target.GetHashCode();

      // assert
      Assert.AreNotEqual(notExpected, actual);
    }

    [Test]
    public void GetHashCode_returns_different_values_with_different_value()
    {
      // arrange
      TagString target;
      int actual;
      int notExpected;

      target = new TagString(string.Empty, "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!");

      notExpected = new TagString(string.Empty, "DIFFERENT").GetHashCode();

      // act
      actual = target.GetHashCode();

      // assert
      Assert.AreNotEqual(notExpected, actual);
    }

    [Test]
    public void Value_can_be_set()
    {
      // arrange
      TagString target;
      string expected;
      string actual;

      expected = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";

      target = new TagString();

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
      TagString target;
      string expected;
      string actual;

      expected = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";

      target = new TagString(string.Empty, "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!");

      // act
      actual = target.ToValueString();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void ToString_returns_string_version_of_tag()
    {
      // arrange
      TagString target;
      string expected;
      string actual;

      expected = "[String: gamma=\"HELLO WORLD THIS IS A TEST STRING ÅÄÖ!\"]";

      target = new TagString("gamma", "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!");

      // act
      actual = target.ToString();

      // assert
      Assert.AreEqual(expected, actual);
    }
  }
}

