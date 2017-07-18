﻿namespace RAGENativeUI.Elements
{
    using System.Drawing;

    using Rage.Native;

    public static class HudColorExtensions
    {
        public static Color GetColor(this HudColor hudColor)
        {
            NativeFunction.Natives.GetHudColour((int)hudColor, out int r, out int g, out int b, out int a);
            return Color.FromArgb(a, r, g, b);
        }

        public static void SetColor(this HudColor hudColor, Color color)
        {
            NativeFunction.Natives.xF314CF4F0211894E((int)hudColor, color.R, color.G, color.B, color.A); // _SET_HUD_COLOUR
        }

        /// <summary>
        /// Gets the name of the specified HUD color. For example, for <see cref="HudColor.WHITE"/> it will return "HUD_COLOUR_WHITE".
        /// </summary>
        /// <remarks>
        /// One of the uses of the returned name is changing the color of the text from notifications, help messages or subtitles.
        /// <code>
        /// Game.DisplayHelp($"~{HudColor.RED.GetName()}~Now this text is red!");
        /// </code>
        /// </remarks>
        /// <param name="hudColor">The HUD color id.</param>
        public static string GetName(this HudColor hudColor)
        {
            return $"HUD_COLOUR_{hudColor}";
        }
    }

    public enum HudColor
    {
        PURE_WHITE = 0,
        WHITE = 1,
        BLACK = 2,
        GREY = 3,
        GREYLIGHT = 4,
        GREYDARK = 5,
        RED = 6,
        REDLIGHT = 7,
        REDDARK = 8,
        BLUE = 9,
        BLUELIGHT = 10,
        BLUEDARK = 11,
        YELLOW = 12,
        YELLOWLIGHT = 13,
        YELLOWDARK = 14,
        ORANGE = 15,
        ORANGELIGHT = 16,
        ORANGEDARK = 17,
        GREEN = 18,
        GREENLIGHT = 19,
        GREENDARK = 20,
        PURPLE = 21,
        PURPLELIGHT = 22,
        PURPLEDARK = 23,
        PINK = 24,
        RADAR_HEALTH = 25,
        RADAR_ARMOUR = 26,
        RADAR_DAMAGE = 27,
        NET_PLAYER1 = 28,
        NET_PLAYER2 = 29,
        NET_PLAYER3 = 30,
        NET_PLAYER4 = 31,
        NET_PLAYER5 = 32,
        NET_PLAYER6 = 33,
        NET_PLAYER7 = 34,
        NET_PLAYER8 = 35,
        NET_PLAYER9 = 36,
        NET_PLAYER10 = 37,
        NET_PLAYER11 = 38,
        NET_PLAYER12 = 39,
        NET_PLAYER13 = 40,
        NET_PLAYER14 = 41,
        NET_PLAYER15 = 42,
        NET_PLAYER16 = 43,
        NET_PLAYER17 = 44,
        NET_PLAYER18 = 45,
        NET_PLAYER19 = 46,
        NET_PLAYER20 = 47,
        NET_PLAYER21 = 48,
        NET_PLAYER22 = 49,
        NET_PLAYER23 = 50,
        NET_PLAYER24 = 51,
        NET_PLAYER25 = 52,
        NET_PLAYER26 = 53,
        NET_PLAYER27 = 54,
        NET_PLAYER28 = 55,
        NET_PLAYER29 = 56,
        NET_PLAYER30 = 57,
        NET_PLAYER31 = 58,
        NET_PLAYER32 = 59,
        SIMPLEBLIP_DEFAULT = 60,
        MENU_BLUE = 61,
        MENU_GREY_LIGHT = 62,
        MENU_BLUE_EXTRA_DARK = 63,
        MENU_YELLOW = 64,
        MENU_YELLOW_DARK = 65,
        MENU_GREEN = 66,
        MENU_GREY = 67,
        MENU_GREY_DARK = 68,
        MENU_HIGHLIGHT = 69,
        MENU_STANDARD = 70,
        MENU_DIMMED = 71,
        MENU_EXTRA_DIMMED = 72,
        BRIEF_TITLE = 73,
        MID_GREY_MP = 74,
        NET_PLAYER1_DARK = 75,
        NET_PLAYER2_DARK = 76,
        NET_PLAYER3_DARK = 77,
        NET_PLAYER4_DARK = 78,
        NET_PLAYER5_DARK = 79,
        NET_PLAYER6_DARK = 80,
        NET_PLAYER7_DARK = 81,
        NET_PLAYER8_DARK = 82,
        NET_PLAYER9_DARK = 83,
        NET_PLAYER10_DARK = 84,
        NET_PLAYER11_DARK = 85,
        NET_PLAYER12_DARK = 86,
        NET_PLAYER13_DARK = 87,
        NET_PLAYER14_DARK = 88,
        NET_PLAYER15_DARK = 89,
        NET_PLAYER16_DARK = 90,
        NET_PLAYER17_DARK = 91,
        NET_PLAYER18_DARK = 92,
        NET_PLAYER19_DARK = 93,
        NET_PLAYER20_DARK = 94,
        NET_PLAYER21_DARK = 95,
        NET_PLAYER22_DARK = 96,
        NET_PLAYER23_DARK = 97,
        NET_PLAYER24_DARK = 98,
        NET_PLAYER25_DARK = 99,
        NET_PLAYER26_DARK = 100,
        NET_PLAYER27_DARK = 101,
        NET_PLAYER28_DARK = 102,
        NET_PLAYER29_DARK = 103,
        NET_PLAYER30_DARK = 104,
        NET_PLAYER31_DARK = 105,
        NET_PLAYER32_DARK = 106,
        BRONZE = 107,
        SILVER = 108,
        GOLD = 109,
        PLATINUM = 110,
        GANG1 = 111,
        GANG2 = 112,
        GANG3 = 113,
        GANG4 = 114,
        SAME_CREW = 115,
        FREEMODE = 116,
        PAUSE_BG = 117,
        FRIENDLY = 118,
        ENEMY = 119,
        LOCATION = 120,
        PICKUP = 121,
        PAUSE_SINGLEPLAYER = 122,
        FREEMODE_DARK = 123,
        INACTIVE_MISSION = 124,
        DAMAGE = 125,
        PINKLIGHT = 126,
        PM_MITEM_HIGHLIGHT = 127,
        SCRIPT_VARIABLE = 128,
        YOGA = 129,
        TENNIS = 130,
        GOLF = 131,
        SHOOTING_RANGE = 132,
        FLIGHT_SCHOOL = 133,
        NORTH_BLUE = 134,
        SOCIAL_CLUB = 135,
        PLATFORM_BLUE = 136,
        PLATFORM_GREEN = 137,
        PLATFORM_GREY = 138,
        FACEBOOK_BLUE = 139,
        INGAME_BG = 140,
        DARTS = 141,
        WAYPOINT = 142,
        MICHAEL = 143,
        FRANKLIN = 144,
        TREVOR = 145,
        GOLF_P1 = 146,
        GOLF_P2 = 147,
        GOLF_P3 = 148,
        GOLF_P4 = 149,
        WAYPOINTLIGHT = 150,
        WAYPOINTDARK = 151,
        PANEL_LIGHT = 152,
        MICHAEL_DARK = 153,
        FRANKLIN_DARK = 154,
        TREVOR_DARK = 155,
        OBJECTIVE_ROUTE = 156,
        PAUSEMAP_TINT = 157,
        PAUSE_DESELECT = 158,
        PM_WEAPONS_PURCHASABLE = 159,
        PM_WEAPONS_LOCKED = 160,
        END_SCREEN_BG = 161,
        CHOP = 162,
        PAUSEMAP_TINT_HALF = 163,
        NORTH_BLUE_OFFICIAL = 164,
        SCRIPT_VARIABLE_2 = 165,
        H = 166,
        HDARK = 167,
        T = 168,
        TDARK = 169,
        HSHARD = 170,
        CONTROLLER_MICHAEL = 171,
        CONTROLLER_FRANKLIN = 172,
        CONTROLLER_TREVOR = 173,
        CONTROLLER_CHOP = 174,
        VIDEO_EDITOR_VIDEO = 175,
        VIDEO_EDITOR_AUDIO = 176,
        VIDEO_EDITOR_TEXT = 177,
        HB_BLUE = 178,
        HB_YELLOW = 179,
        VIDEO_EDITOR_SCORE = 180,
        VIDEO_EDITOR_AUDIO_FADEOUT = 181,
        VIDEO_EDITOR_TEXT_FADEOUT = 182,
        VIDEO_EDITOR_SCORE_FADEOUT = 183,
        HEIST_BACKGROUND = 184,
        VIDEO_EDITOR_AMBIENT = 185,
        VIDEO_EDITOR_AMBIENT_FADEOUT = 186,
        GB = 187,
        G = 188,
        B = 189,
        LOW_FLOW = 190,
        LOW_FLOW_DARK = 191,
        G1 = 192,
        G2 = 193,
        G3 = 194,
        G4 = 195,
        G5 = 196,
        G6 = 197,
        G7 = 198,
        G8 = 199,
        G9 = 200,
        G10 = 201,
        G11 = 202,
        G12 = 203,
        G13 = 204,
        G14 = 205,
        G15 = 206,
        ADVERSARY = 207,
        DEGEN_RED = 208,
        DEGEN_YELLOW = 209,
        DEGEN_GREEN = 210,
        DEGEN_CYAN = 211,
        DEGEN_BLUE = 212,
        DEGEN_MAGENTA = 213,
        STUNT_1 = 214,
        STUNT_2 = 215,
        SPECIAL_RACE_SERIES = 216,
        SPECIAL_RACE_SERIES_DARK = 217,
        CS = 218,
        CS_DARK = 219,
    }
}
