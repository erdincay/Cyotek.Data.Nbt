using System;
using System.Collections.Generic;

namespace Cyotek.Data.Nbt
{
  public sealed class TagList : Tag, ICollectionTag
  {
    #region Fields

    private TagCollection _value;

    #endregion

    #region Constructors

    public TagList()
      : this(string.Empty)
    { }

    public TagList(string name)
      : this(name, TagType.None)
    { }

    public TagList(TagType listType)
      : this(string.Empty, listType)
    { }

    public TagList(TagCollection value)
      : this(string.Empty, value)
    { }

    public TagList(string name, TagType listType)
      : this(name, listType, new TagCollection(listType))
    { }

    public TagList(string name, TagCollection value)
      : this(name, value.LimitType, value)
    { }

    public TagList(string name, TagType listType, TagCollection value)
      : base(name)
    {
      this.ListType = listType;
      this.Value = value;
    }

    #endregion

    #region Properties

    public int Count
    {
      get { return this.Value.Count; }
    }

    public TagType ListType
    {
      get { return this.Value?.LimitType ?? TagType.None; }
      set
      {
        if (this.Value == null || this.Value.LimitType != value)
        {
          this.Value = new TagCollection(this, value);
        }
      }
    }

    public override TagType Type
    {
      get { return TagType.List; }
    }

    public TagCollection Value
    {
      get { return _value; }
      set
      {
        if (!ReferenceEquals(_value, value))
        {
          if (value == null)
          {
            throw new ArgumentNullException(nameof(value));
          }

          _value = value;
          value.Owner = this;

          this.OnValueChanged(EventArgs.Empty);
        }
      }
    }

    #endregion

    #region Methods

    public override object GetValue()
    {
      return _value;
    }

    public override void SetValue(object value)
    {
      this.Value = (TagCollection)value;
    }

    public override string ToString(string indentString)
    {
      return $"{indentString}[List: {this.Name}] ({this.Value?.Count ?? 0} items)";
    }

    public override string ToValueString()
    {
      return _value?.ToString() ?? string.Empty;
    }

    #endregion

    #region ICollectionTag Interface

    bool ICollectionTag.IsList
    {
      get { return true; }
    }

    TagType ICollectionTag.LimitToType
    {
      get { return this.ListType; }
      set { this.ListType = value; }
    }

    IList<Tag> ICollectionTag.Values
    {
      get { return this.Value; }
    }

    #endregion
  }
}
