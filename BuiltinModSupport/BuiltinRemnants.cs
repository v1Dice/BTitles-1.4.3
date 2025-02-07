using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace BTitles.BuiltinModSupport;

public class BuiltinRemnants : AutoImplementedModSupport
{
    protected override string GetTargetModName() => "Remnants";

    protected override void GetData(out Dictionary<string, BiomeEntry> miniBiomes, out Dictionary<string, BiomeEntry> biomes)
    {
        miniBiomes = new Dictionary<string, BiomeEntry>
        {
            {"MarbleCave",   new BiomeEntry{ Title = "Marble Cave",   SubTitle = "Remnants", TitleColor = Color.LightGray,   StrokeColor = Color.Black }},
            {"GraniteCave",  new BiomeEntry{ Title = "Granite Cave",  SubTitle = "Remnants", TitleColor = Color.SkyBlue,     StrokeColor = Color.Black }},
            {"OceanCave",    new BiomeEntry{ Title = "Ocean Cave",    SubTitle = "Remnants", TitleColor = Color.HotPink,     StrokeColor = Color.Black }},
            {"Undergrowth",  new BiomeEntry{ Title = "Undergrowth",   SubTitle = "Remnants", TitleColor = Color.ForestGreen, StrokeColor = Color.Black }},
            {"AerialGarden", new BiomeEntry{ Title = "Aerial Garden", SubTitle = "Remnants", TitleColor = Color.Turquoise,   StrokeColor = Color.Black }},
            {"ForgottenTomb",new BiomeEntry{ Title = "Forgotten Tomb",SubTitle = "Remnants", TitleColor = Color.DimGray,     StrokeColor = Color.Black }},
            {"MagicalLab",   new BiomeEntry{ Title = "Magical Lab",   SubTitle = "Remnants", TitleColor = Color.LightPink,   StrokeColor = Color.Black }},
            {"EchoingHalls", new BiomeEntry{ Title = "Echoing Halls", SubTitle = "Remnants", TitleColor = Color.LightSlateGray, StrokeColor = Color.Black }},
            {"Pyramid",      new BiomeEntry{ Title = "Pyramid",       SubTitle = "Remnants", TitleColor = Color.Goldenrod,   StrokeColor = Color.Black }},
            {"Hive",         new BiomeEntry{ Title = "Giant Hive",    SubTitle = "Remnants", TitleColor = Color.Gold,        StrokeColor = Color.Black }},
            {"JungleTemple", new BiomeEntry{ Title = "Jungle Temple", SubTitle = "Remnants", TitleColor = Color.Yellow,      StrokeColor = Color.Black }},
        };

        biomes = null;
    }
}
