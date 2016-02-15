using System.Globalization;
using System.Linq;

namespace Cyotek.Data.Nbt
{
  public class TagIntArray : Tag
  {
    #region Constructors

    public TagIntArray()
      : this(string.Empty, new int[0])
    { }

    public TagIntArray(string name)
      : this(name, new int[0])
    { }

    public TagIntArray(int[] value)
      : this(string.Empty, value)
    { }

    public TagIntArray(string name, int[] value)
    {
      this.Name = name;
      this.Value = value;
    }

    #endregion

    #region Properties

    public override TagType Type
    {
      get { return TagType.IntArray; }
    }

    public new int[] Value
    {
      get { return (int[])base.Value; }
      set { base.Value = value; }
    }

    #endregion

    #region Methods

    public override string ToString(string indentString)
    {
      return $"{indentString}[IntArray: {this.Name}={this.Value?.Length ?? 0} values]";
    }

    public override string ToValueString()
    {
      return string.Join(", ", this.Value.Select(b => b.ToString(CultureInfo.InvariantCulture)).
                                    ToArray());
    }

    #endregion
  }
}
