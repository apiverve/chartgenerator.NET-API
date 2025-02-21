using System;
using System.Collections.Generic;
using System.Text;

namespace APIVerve
{
    public class ChartGeneratorQueryOptions {
public string type { get; set; }
public array data[labels] { get; set; }
public string data[datasets][0][label] { get; set; }
public array data[datasets][0][data] { get; set; }
public string data[datasets][1][label] { get; set; }
public array data[datasets][1][data] { get; set; }
}

}
