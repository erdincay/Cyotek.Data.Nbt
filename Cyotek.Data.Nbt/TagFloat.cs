namespace Cyotek.Data.Nbt
{
  public class TagFloat : Tag
  {
    #region Public Constructors

    public TagFloat()
      : this(string.Empty, 0)
    { }

    public TagFloat(string name)
      : this(name, 0)
    { }

    public TagFloat(float value)
      : this(string.Empty, value)
    { }

    public TagFloat(string name, float value)
    {
      this.Name = name;
      this.Value = value;
    }

    #endregion

    #region Overridden Properties

    public override TagType Type
    {
      get { return TagType.Float; }
    }

    #endregion

    #region Overridden Methods

    public override string ToString(string indentString)
    {
      return $"{indentString}[Float: {this.Name}={this.Value}]";
    }

    #endregion

    #region Public Properties

    public new float Value
    {
      get { return (float)base.Value; }
      set { base.Value = value; }
    }

    #endregion
  }
}
