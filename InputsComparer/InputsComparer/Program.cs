using InputsComparer;
using Newtonsoft.Json;

List<string> rtsFiles = Directory.GetFiles(@"C:\Users\Yugandhar.Reddy\Desktop\RTS").ToList();
List<MxAInput> rtsInputs = new List<MxAInput>();
foreach(string rtsFile in rtsFiles)
{
    rtsInputs.AddRange(JsonConvert.DeserializeObject<List<MxAInput>>(File.ReadAllText(rtsFile)) ?? new List<MxAInput>());
}
List<string> adiFiles = Directory.GetFiles(@"C:\Users\Yugandhar.Reddy\Desktop\ADI").ToList();
List<MxAInput> adiInputs = new List<MxAInput>();
foreach (string adiFile in adiFiles)
{
    adiInputs.AddRange(JsonConvert.DeserializeObject<List<MxAInput>>(File.ReadAllText(adiFile)) ?? new List<MxAInput>());
}

for(int i = 0; i < rtsInputs.Count; i++)
{
    MxAInput rtsRow = rtsInputs[i];
    MxAInput adiRow = adiInputs[i];
    if(Math.Abs(rtsRow.DateTime - (adiRow.DateTime + 10800)) > 0.1)
    {
        Console.WriteLine(i);
    }
    if (Math.Abs(rtsRow.Depth - adiRow.Depth) > 0.1)
    {
        Console.WriteLine(i);
    }
    if (Math.Abs(rtsRow.OnBtm - adiRow.OnBtm) > 0.1)
    {
        Console.WriteLine(i);
    }
    if (Math.Abs(rtsRow.InSlips - adiRow.InSlips) > 0.1)
    {
        Console.WriteLine(i + "InSlips");
    }
    if (Math.Abs(rtsRow.HoleDepth - adiRow.HoleDepth) > 0.1)
    {
        Console.WriteLine(i);
    }
    if (Math.Abs(rtsRow.TDActivity - adiRow.TDActivity) > 0.1)
    {
        Console.WriteLine(i + "TDActivity");
    }
    if (Math.Abs(rtsRow.BlockPosition - adiRow.BlockPosition) > 0.1)
    {
        Console.WriteLine(i);
    }
    if (Math.Abs(rtsRow.Rpm - adiRow.Rpm) > 0.1)
    {
        Console.WriteLine(i);
    }
    if (Math.Abs(rtsRow.FlowIn - adiRow.FlowIn) > 0.1)
    {
        Console.WriteLine(i);
    }
    if (Math.Abs(rtsRow.Hookload - adiRow.Hookload) > 0.1)
    {
        Console.WriteLine(i);
    }
    if (Math.Abs(rtsRow.Wob - adiRow.Wob) > 0.1)
    {
        Console.WriteLine(i);
    }
    if (Math.Abs(rtsRow.Torque - adiRow.Torque) > 0.1)
    {
        Console.WriteLine(i);
    }
    if (Math.Abs(rtsRow.SPP - adiRow.SPP) > 0.1)
    {
        Console.WriteLine(i);
    }
    if (Math.Abs(rtsRow.RunningSpeed - adiRow.RunningSpeed) > 0.1)
    {
        Console.WriteLine(i + "RunningSpeed");
    }
    if (rtsRow.IsRealtime != adiRow.IsRealtime)
    {
        Console.WriteLine(i);
    }
    if (rtsRow.IsNewDepthData != adiRow.IsNewDepthData)
    {
        Console.WriteLine(i);
    }
}

Console.ReadLine();