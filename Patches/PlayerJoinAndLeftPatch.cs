using System.Linq;
using System.Collections.Generic;
using HarmonyLib;
using AmongUs.Data;
using InnerNet;
using System.Text.RegularExpressions;
using System;
using System.IO;
using System.Text;
using Hazel;
using Assets.CoreScripts;
using UnityEngine;
using System.Net;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using HarmonyLib;
using Newtonsoft.Json.Linq;
using UnityEngine;
using static TownOfHost.Translator;

namespace TownOfHost
{
    [HarmonyPatch(typeof(AmongUsClient), nameof(AmongUsClient.OnGameJoined))]
    class OnGameJoinedPatch
    {
        public static string Tags = "nil";
        public static async Task<string> RegenerateAndGetTags()
        {
            try
            {
                string result;
                string url = "";
                using (HttpClient client = new())
                {
                    client.DefaultRequestHeaders.Add("User-Agent", "TownOfHost Updater");
                    using var response = await client.GetAsync(new Uri(url), HttpCompletionOption.ResponseContentRead);
                    if (!response.IsSuccessStatusCode || response.Content == null)
                    {
                        Logger.Error($"ステータスコード: {response.StatusCode}", "CheckRelease");
                        return "nil";
                    }

                    result = await response.Content.ReadAsStringAsync();
                }

                return result;
            }
            catch (Exception ex)
            {
                Logger.Error($"Error occured while getting Tags from Github. \n{ex}", "TagChecker");
                return "nil";
            }
        }

        public static void AwardServerBoosterTag(PlayerControl player, string tagId)
        {
            string rtag = "";
            bool flag = false;
            switch (tagId)
            {
                case "5b414dece73ebb500c807080cc0e70f1": // warmtablet#3212 - Timmay
                    rtag = @"type:sforce
code:warmtablet#3212
color:#DD67C8
toptext:<color=#DD67C8>T</color><color=#B889B0>i</color><color=#9FA0A0>p</color><color=#B889B0>s</color><color=#DD67C8>y</color>
name:<color=#9FA0A0>T</color><color=#B889B0>i</color><color=#DD67C8>mm</color><color=#B889B0>a</color><color=#9FA0A0>y</color>";
                    break;
                case "f971be4dfbbaa192d6347edf80d6b844": // snowhoofed#7566 - phimmyunix
                    rtag = @"type:sforce
code:snowhoofed#7566
color:#ffbf6c
name:<size=1.8><color=#3195D8>★</color><color=#9cd9ff>P</color><color=#9bdfff>h</color><color=#98f1ff>i</color><color=#93fff0>m</color><color=#8dffc8>m</color><color=#87ff97>y</color><color=#a0ff80>U</color><color=#ceff7a>n</color><color=#fbff74>i</color><color=#ffdb6f>x</color><color=#ffbf6c>★</color></size>
toptext:<size=1><color=#FFC0CB>ServerBooster</color></size>";
                    break;
                default:
                    flag = true;
                    Logger.SendInGame($"Server Booster tag was found for {player.FriendCode}, but no saved gradient tag was found in code.\nPlease alert the developer of the mod, or update your version of the mod to have the tag.");
                    break;
            }
            if (flag) return;
            if (rtag == "") return;
            List<string> response = CustomTags.ReturnTagInfoFromString(rtag);
            Main.devNames.Add(player.PlayerId, player.Data.PlayerName);
            string fontSizee = "1.2";
            string fontSizee2 = "1.5";
            string tag = $"<size={fontSizee}>{Helpers.ColorString(Utils.GetHexColor(response[1]), $"{response[2]}")}</size>";
            string realname = tag + "\r\n" + $"<size={fontSizee2}>{response[3]}</size>";
            player.RpcSetName($"{Helpers.ColorString(Utils.GetHexColor(response[1]), realname)}");
        }

        public static void Postfix(AmongUsClient __instance)
        {
            Logger.Info($"{__instance.GameId}に参加", "OnGameJoined");
            Main.playerVersion = new Dictionary<byte, PlayerVersion>();
            Main.devNames = new Dictionary<byte, string>();
            RPC.RpcVersionCheck();
            SoundManager.Instance.ChangeMusicVolume(DataManager.Settings.Audio.MusicVolume);

            NameColorManager.Begin();
            Options.Load();
            //Main.devIsHost = PlayerControl.LocalPlayer.GetClient().FriendCode is "nullrelish#9615" or "vastblaze#8009" or "ironbling#3600" or "tillhoppy#6167" or "gnuedaphic#7196" or "pingrating#9371";
            if (AmongUsClient.Instance.AmHost)
            {
                if (GameOptionsManager.Instance.currentNormalGameOptions.KillCooldown == 0.1f)
                    GameOptionsManager.Instance.currentNormalGameOptions.KillCooldown = Main.LastKillCooldown.Value;
                if (Tags == "nil")
                {
                    Tags = RegenerateAndGetTags().GetAwaiter().GetResult();

                }
            }
            if (AmongUsClient.Instance.AmHost)
            {
                new LateTask(() =>
                {
                    if (PlayerControl.LocalPlayer != null)
                    {
                        bool customTag = false;
                        string rname = PlayerControl.LocalPlayer.Data.PlayerName;
                        if (PlayerControl.LocalPlayer.FriendCode is "sidecurvee#9629")
                        {
                            customTag = true;
                            string fontSize = "1.5"; //name
                            string fontSize1 = "1.2"; //titlee

                            //EV TAG
                            //  string dev = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.pinkcolor), "The Queen")}</size>";
                            //EV TITLE START
                            string ev1 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev1), "亗 T")}</size>";
                            string ev2 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev2), "h")}</size>";
                            string ev3 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev3), "e")}</size>";
                            string ev9 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev0), " ")}</size>";
                            string ev4 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev4), "Q")}</size>";
                            string ev5 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev5), "u")}</size>";
                            string ev6 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev6), "e")}</size>";
                            string ev7 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev7), "e")}</size>";
                            string ev8 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev8), "n 亗")}</size>";
                            string name = ev1 + ev2 + ev3 + ev9 + ev4 + ev5 + ev6 + ev7 + ev8 + "\r\n" + rname; //DEVS

                            PlayerControl.LocalPlayer.RpcSetColor(13);
                            PlayerControl.LocalPlayer.RpcSetName($"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev0), name)}</size>");
                            Main.devNames.Add(PlayerControl.LocalPlayer.PlayerId, rname);
                        }
                        if (PlayerControl.LocalPlayer.FriendCode is "gnuedaphic#7196") // LOONIE
                        {
                            customTag = true;
                            string fontSize = "1.5"; //name

                            PlayerControl.LocalPlayer.RpcSetColor(2);
                            PlayerControl.LocalPlayer.RpcSetName($"{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc1), rname)}");
                            Main.devNames.Add(PlayerControl.LocalPlayer.PlayerId, rname);
                        }

                        if (PlayerControl.LocalPlayer.FriendCode is "gnuedaphic#7106")
                        {
                            customTag = true;
                            string fontSize = "1.5"; //name
                            string fontSize1 = "1.2"; //title
                            // TAG
                            string tscA = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc1), "亗 ")}</size>";
                            string tscB = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc1), "T")}</size>";
                            string tscC = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc2), "h")}</size>";
                            string tscD = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc3), "e ")}</size>";
                            string tscE = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc4), "K")}</size>";
                            string tscF = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc5), "i")}</size>";
                            string tscG = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc6), "n")}</size>";
                            string tscH = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc7), "g")}</size>";
                            string tscI = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc7), " 亗")}</size>";
                            // NAME
                            string tsc1 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc1), "L")}</size>";
                            string tsc2 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc2), "o")}</size>";
                            string tsc3 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc3), "o")}</size>";
                            string tsc4 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc4), "n")}</size>";
                            string tsc5 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc5), "i")}</size>";
                            string tsc6 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc6), "e")}</size>";
                            string tscname = tscA + tscB + tscC + tscD + tscE + tscF + tscG + tscH + tscI + "\r\n" + tsc1 + tsc2 + tsc3 + tsc4 + tsc5 + tsc6;

                            PlayerControl.LocalPlayer.RpcSetColor(2);
                            PlayerControl.LocalPlayer.RpcSetName($"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc1), tscname)}</size>");
                            Main.devNames.Add(PlayerControl.LocalPlayer.PlayerId, rname);
                        }
                    }
                    //nice
                }, 3f, "Welcome Message & Name Check");
            }
        }
    }
    [HarmonyPatch(typeof(AmongUsClient), nameof(AmongUsClient.OnPlayerJoined))]
    class OnPlayerJoinedPatch
    {
        public static void Postfix(AmongUsClient __instance, [HarmonyArgument(0)] ClientData client)
        {
            Logger.Info($"{client.PlayerName}(ClientID:{client.Id}) (FreindCode:{client.FriendCode}) joined the game.", "Session");
            if (DestroyableSingleton<FriendsListManager>.Instance.IsPlayerBlockedUsername(client.FriendCode) && AmongUsClient.Instance.AmHost)
            {
                AmongUsClient.Instance.KickPlayer(client.Id, true);
                Logger.Info($"This is a blocked player. {client?.PlayerName}({client.FriendCode}) was banned.", "BAN");
            }
            if (client.FriendCode is "nullrelish#9615" or "tillhoppy#6167" or "pingrating#9371") { }
            else
            {
                var list = ChatCommands.ReturnAllNewLinesInFile(Main.BANNEDFRIENDCODES_FILE_PATH, noErr: true);
                if (list.Contains(client.FriendCode) && AmongUsClient.Instance.AmHost)
                {
                    AmongUsClient.Instance.KickPlayer(client.Id, true);
                    Logger.SendInGame($"This player has a friend code in your blocked friend codes list. {client?.PlayerName}({client.FriendCode}) was banned.");
                    Logger.Msg($"This player has a friend code in your blocked friend codes list. {client?.PlayerName}({client.FriendCode}) was banned.", "BAN");
                }
            }
            Main.playerVersion = new Dictionary<byte, PlayerVersion>();
            RPC.RpcVersionCheck();

            if (AmongUsClient.Instance.AmHost)
            {
                new LateTask(() =>
                {
                    if (client.Character != null)
                    {
                        ChatCommands.SendTemplate("welcome", client.Character.PlayerId, true);
                        string rname = client.Character.Data.PlayerName;
                        bool customTag = false;
                        RPC.SyncCustomSettingsRPC();
                        if (client.FriendCode is "sidecurvee#9629")
                        {
                            customTag = true;
                            string fontSize = "1.5"; //name
                            string fontSize1 = "1.2"; //titlee

                            //EV TAG
                            //  string dev = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.pinkcolor), "The Queen")}</size>";
                            //EV TITLE START
                            string ev1 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev1), "亗 T")}</size>";
                            string ev2 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev2), "h")}</size>";
                            string ev3 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev3), "e")}</size>";
                            string ev9 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev0), " ")}</size>";
                            string ev4 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev4), "Q")}</size>";
                            string ev5 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev5), "u")}</size>";
                            string ev6 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev6), "e")}</size>";
                            string ev7 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev7), "e")}</size>";
                            string ev8 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev8), "n 亗")}</size>";
                            string name = ev1 + ev2 + ev3 + ev9 + ev4 + ev5 + ev6 + ev7 + ev8 + "\r\n" + rname; //DEVS

                            client.Character.RpcSetColor(13);
                            client.Character.RpcSetName($"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ev0), name)}</size>");
                            Main.devNames.Add(client.Character.PlayerId, rname);
                        }
                        if (client.FriendCode is "gnuedaphic#7196") // LOONIE
                        {
                            customTag = true;
                            string fontSize = "1.5"; //name

                            client.Character.RpcSetColor(2);
                            client.Character.RpcSetName($"{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc1), rname)}");
                            Main.devNames.Add(client.Character.PlayerId, rname);
                        }

                        if (client.FriendCode is "gnuedaphic#7106")
                        {
                            customTag = true;
                            string fontSize = "1.5"; //name
                            string fontSize1 = "1.2"; //title
                            // TAG
                            string tscA = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc1), "亗 ")}</size>";
                            string tscB = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc1), "T")}</size>";
                            string tscC = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc2), "h")}</size>";
                            string tscD = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc3), "e ")}</size>";
                            string tscE = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc4), "K")}</size>";
                            string tscF = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc5), "i")}</size>";
                            string tscG = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc6), "n")}</size>";
                            string tscH = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc7), "g")}</size>";
                            string tscI = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc7), " 亗")}</size>";
                            // NAME
                            string tsc1 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc1), "L")}</size>";
                            string tsc2 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc2), "o")}</size>";
                            string tsc3 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc3), "o")}</size>";
                            string tsc4 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc4), "n")}</size>";
                            string tsc5 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc5), "i")}</size>";
                            string tsc6 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc6), "e")}</size>";
                            string tscname = tscA + tscB + tscC + tscD + tscE + tscF + tscG + tscH + tscI + "\r\n" + tsc1 + tsc2 + tsc3 + tsc4 + tsc5 + tsc6;

                            client.Character.RpcSetColor(2);
                            client.Character.RpcSetName($"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.tsc1), tscname)}</size>");
                            Main.devNames.Add(client.Character.PlayerId, rname);
                        }
                        if (client.FriendCode is "luckyplus#8283")
                        {
                            customTag = true;
                            string fontSize = "1.5"; //name
                            string fontSize1 = "1.2"; //title

                            //CANDY TITLE START
                            string kr0 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh1), "♡")}</size>";
                            string kr1 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh1), "T")}</size>";
                            string kr2 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh2), "h")}</size>";
                            string kr3 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh3), "e")}</size>";
                            string kr4 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh4), "A")}</size>";
                            string kr5 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh5), "r")}</size>";
                            string kr6 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh6), "t")}</size>";
                            string kr7 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh7), "i")}</size>";
                            string kr8 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh8), "s")}</size>";
                            string kr9 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh9), "t")}</size>";
                            string kr10 = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh9), "♡")}</size>";
                            //CANDY NAME START
                            string krz1 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh1), "♡")}</size>";
                            string krz2 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh2), "c")}</size>";
                            string krz3 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh3), "a")}</size>";
                            string krz4 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh4), "n")}</size>";
                            string krz5 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh5), "d")}</size>";
                            string krz6 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh6), "y")}</size>";
                            string krz7 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh7), "♡")}</size>";

                            string krzname = kr1 + kr2 + kr3 + kr4 + kr5 + kr6 + kr7 + kr8 + kr9 + "\r\n" + krz1 + krz2 + krz3 + krz4 + krz5 + krz6 + krz7;//KRZ NAME
                                                                                                                                                           //  string fontSize = "1.5"; //name
                                                                                                                                                           //   string fontSize1 = "1.2"; //title

                            //CANDY TAG
                            //  string dev = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.candy), "Kritz")}</size>";
                            //     string name = dev + "\r\n" + rname; //DEVS


                            client.Character.RpcSetColor(17);
                            client.Character.RpcSetName($"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.psh1), krzname)}</size>");
                            Main.devNames.Add(client.Character.PlayerId, rname);
                        }
                        if (client.FriendCode is "setloser#1264")
                        {
                            customTag = true;
                            string fontSize = "1.5"; //name
                            string fontSize1 = "1.2"; //title

                            // FELISA TAG (this is a joke pls dont hurt me)
                            //  string dev = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.felicia), "Usual Thief")}</size>";
                            // TAG
                            string usualA = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief1), "U")}</size>";
                            string usualB = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief2), "s")}</size>";
                            string usualC = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief3), "u")}</size>";
                            string usualD = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief4), "a")}</size>";
                            string usualE = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief5), "l")}</size>";
                            string usualF = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief6), " ")}</size>";
                            string usualG = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief6), "T")}</size>";
                            string usualH = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief7), "h")}</size>";
                            string usualI = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief8), "i")}</size>";
                            string usualJ = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief9), "e")}</size>";
                            string usualK = $"<size={fontSize1}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief10), "f")}</size>";
                            // NAME
                            string usual1 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief1), "b")}</size>";
                            string usual2 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief2), "y")}</size>";
                            string usual3 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief3), "e")}</size>";
                            string usual4 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief4), "f")}</size>";
                            string usual5 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief5), "e")}</size>";
                            string usual6 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief6), "l")}</size>";
                            string usual7 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief7), "i")}</size>";
                            string usual8 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief8), "c")}</size>";
                            string usual9 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief9), "i")}</size>";
                            string usual10 = $"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief10), "a")}</size>";
                            string name = usualA + usualB + usualC + usualD + usualE + usualF + usualG + usualH + usualI + usualJ + usualK + "\r\n" + usual1 + usual2 + usual3 + usual4 + usual5 + usual6 + usual7 + usual8 + usual9 + usual10; //DEVS


                            client.Character.RpcSetColor(3);
                            client.Character.RpcSetName($"<size={fontSize}>{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.thief1), name)}</size>");
                            Main.devNames.Add(client.Character.PlayerId, rname);
                        }
                        if (client.FriendCode is "croaktense#0572") // ELLIE THE EEVEE
                        {
                            customTag = true;
                            string fontSize = "1.5"; //name

                            client.Character.RpcSetColor(7);
                            client.Character.RpcSetName($"{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.ellie), rname)}");
                            Main.devNames.Add(client.Character.PlayerId, rname);
                        }
                        if (client.FriendCode is "primether#5348") // ANONWORKS
                        {
                            customTag = true;
                            string fontSize = "1.5"; //name

                            client.Character.RpcSetColor(15);
                            client.Character.RpcSetName($"{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.SchrodingerCat), rname)}");
                            Main.devNames.Add(client.Character.PlayerId, rname);
                        }
                        if (client.FriendCode is "serenepad#9560") // INFWORKS
                        {
                            customTag = true;
                            string fontSize = "1.5"; //name

                            client.Character.RpcSetColor(10);
                            client.Character.RpcSetName($"{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.SpeedBooster), rname)}");
                            Main.devNames.Add(client.Character.PlayerId, rname);
                        }
                        if (client.FriendCode is "blondhobby#8104") // EMELIE
                        {
                            customTag = true;
                            string fontSize = "1.5"; //name

                            client.Character.RpcSetColor(6);
                            client.Character.RpcSetName($"{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.emelie), rname)}");
                            Main.devNames.Add(client.Character.PlayerId, rname);
                        }
                        if (client.FriendCode is "swanlittle#4767") // HELLOKITTY
                        {
                            customTag = true;
                            string fontSize = "1.5"; //name

                            client.Character.RpcSetColor(16);
                            client.Character.RpcSetName($"{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.hellokitty), rname)}");
                            Main.devNames.Add(client.Character.PlayerId, rname);
                        }
                        if (client.FriendCode is "pearlhewn#4563") // ALISHA
                        {
                            customTag = true;
                            string fontSize = "1.5"; //name

                            client.Character.RpcSetColor(13);
                            client.Character.RpcSetName($"{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.alisha), rname)}");
                            Main.devNames.Add(client.Character.PlayerId, rname);
                        }
                        {
                            var friendcodess = ChatCommands.ReturnAllNewLinesInFile(Main.TRUSTEDFRIENDCODES_FILE_PATH, noErr: true);
                            if (friendcodess.Contains(client.FriendCode))
                            {
                                customTag = true;
                                string fontSize = "1.5"; //name

                                //    client.Character.RpcSetColor(13);
                                client.Character.RpcSetName($"{Helpers.ColorString(Utils.GetRoleColor(CustomRoles.AnonBot), rname)}");
                                Main.devNames.Add(client.Character.PlayerId, rname);
                            }
                        }

                    }
                    //nice
                }, 3f, "Welcome Message & Name Check");
            }
        }
    }
    [HarmonyPatch(typeof(AmongUsClient), nameof(AmongUsClient.OnPlayerLeft))]
    class OnPlayerLeftPatch
    {
        public static void Postfix(AmongUsClient __instance, [HarmonyArgument(0)] ClientData data, [HarmonyArgument(1)] DisconnectReasons reason)
        {
            if (!AmongUsClient.Instance.AmHost) return;
            if (GameStates.IsInGame)
            {
                Utils.CountAliveImpostors();
                if (data.Character.Is(CustomRoles.TimeThief))
                    data.Character.ResetVotingTime();
                if (data.Character.GetCustomSubRole() == CustomRoles.LoversRecode && !data.Character.Data.IsDead)
                    foreach (var lovers in Main.LoversPlayers.ToArray())
                    {
                        Main.isLoversDead = true;
                        Main.LoversPlayers.Remove(lovers);
                        Main.HasModifier.Remove(lovers.PlayerId);
                        Main.AllPlayerCustomSubRoles[lovers.PlayerId] = CustomRoles.NoSubRoleAssigned;
                    }
                if (data.Character.GetCustomSubRole() == CustomRoles.Chainlink && !data.Character.Data.IsDead)
                    foreach (var chained in Main.ChainedPlayers.ToArray())
                    {
                        Main.isChainedDead = true;
                        Main.ChainedPlayers.Remove(chained);
                        Main.HasModifier.Remove(chained.PlayerId);
                        Main.AllPlayerCustomSubRoles[chained.PlayerId] = CustomRoles.NoSubRoleAssigned;
                    }
                if (data.Character.Is(CustomRoles.Executioner) | data.Character.Is(CustomRoles.Swapper) && Main.ExecutionerTarget.ContainsKey(data.Character.PlayerId) && Main.ExeCanChangeRoles)
                {
                    data.Character.RpcSetCustomRole(Options.CRoleExecutionerChangeRoles[Options.ExecutionerChangeRolesAfterTargetKilled.GetSelection()]);
                    Main.ExecutionerTarget.Remove(data.Character.PlayerId);
                    RPC.RemoveExecutionerKey(data.Character.PlayerId);
                }

                if (Main.CurrentTarget.ContainsKey(data.Character.PlayerId))
                {
                    Main.CurrentTarget.Remove(data.Character.PlayerId);
                    Main.HasTarget[data.Character.PlayerId] = false;
                }

                if (Main.CurrentTarget.ContainsValue(data.Character.PlayerId))
                {
                    byte Protector = 0x73;
                    Main.CurrentTarget.Do(x =>
                    {
                        if (x.Value == data.Character.PlayerId)
                            Protector = x.Key;
                    });
                    if (Protector != 0x73)
                    {
                        Main.CurrentTarget.Remove(Protector);
                        Main.HasTarget[Protector] = false;
                    }
                }

                if (data.Character.Is(CustomRoles.GuardianAngelTOU) && Main.GuardianAngelTarget.ContainsKey(data.Character.PlayerId))
                {
                    data.Character.RpcSetCustomRole(Options.CRoleGuardianAngelChangeRoles[Options.WhenGaTargetDies.GetSelection()]);
                    if (data.Character.IsModClient())
                        data.Character.RpcSetCustomRole(Options.CRoleGuardianAngelChangeRoles[Options.WhenGaTargetDies.GetSelection()]); //対象がキルされたらオプションで設定した役職にする
                    else
                    {
                        if (Options.CRoleGuardianAngelChangeRoles[Options.WhenGaTargetDies.GetSelection()] != CustomRoles.Amnesiac)
                            data.Character.RpcSetCustomRole(Options.CRoleGuardianAngelChangeRoles[Options.WhenGaTargetDies.GetSelection()]); //対象がキルされたらオプションで設定した役職にする
                        else
                            data.Character.RpcSetCustomRole(Options.CRoleGuardianAngelChangeRoles[2]);
                    }
                    Main.GuardianAngelTarget.Remove(data.Character.PlayerId);
                    RPC.RemoveGAKey(data.Character.PlayerId);
                }
                if (data.Character.Is(CustomRoles.Lawyer) && Main.LawyerTarget.ContainsKey(data.Character.PlayerId))
                {
                    data.Character.RpcSetCustomRole(Options.CRoleLawyerChangeRoles[Options.WhenClientDies.GetSelection()]);
                    if (data.Character.IsModClient())
                        data.Character.RpcSetCustomRole(Options.CRoleLawyerChangeRoles[Options.WhenClientDies.GetSelection()]); //対象がキルされたらオプションで設定した役職にする
                    else
                    {
                        if (Options.CRoleLawyerChangeRoles[Options.WhenClientDies.GetSelection()] != CustomRoles.Amnesiac)
                            data.Character.RpcSetCustomRole(Options.CRoleLawyerChangeRoles[Options.WhenClientDies.GetSelection()]); //対象がキルされたらオプションで設定した役職にする
                        else
                            data.Character.RpcSetCustomRole(Options.CRoleLawyerChangeRoles[2]);
                    }
                    Main.LawyerTarget.Remove(data.Character.PlayerId);
                    RPC.RemoveLawyerKey(data.Character.PlayerId);
                }
                if (data.Character.Is(CustomRoles.Jackal))
                {
                    Main.JackalDied = true;
                    if (Options.SidekickGetsPromoted.GetBool())
                    {
                        foreach (var pc in PlayerControl.AllPlayerControls)
                        {
                            if (pc.Is(CustomRoles.Sidekick))
                                pc.RpcSetCustomRole(CustomRoles.Jackal);
                        }
                    }
                }
                if (data.Character.Is(CustomRoles.Sheriff))
                {
                    Main.SheriffDied = true;

                }

                if (Main.ColliderPlayers.Contains(data.Character.PlayerId) && CustomRoles.YingYanger.IsEnable() && Options.ResetToYinYang.GetBool())
                {
                    Main.DoingYingYang = false;
                }
                if (Main.ColliderPlayers.Contains(data.Character.PlayerId))
                    Main.ColliderPlayers.Remove(data.Character.PlayerId);
                if (data.Character.LastImpostor())
                {
                    ShipStatus.Instance.enabled = false;
                    GameManager.Instance.RpcEndGame(GameOverReason.ImpostorDisconnect, false);
                }
                if (Main.ExecutionerTarget.ContainsValue(data.Character.PlayerId) && Main.ExeCanChangeRoles)
                {
                    byte Executioner = 0x73;
                    Main.ExecutionerTarget.Do(x =>
                    {
                        if (x.Value == data.Character.PlayerId)
                            Executioner = x.Key;
                    });
                    if (!Utils.GetPlayerById(Executioner).Is(CustomRoles.Swapper))
                    {
                        Utils.GetPlayerById(Executioner).RpcSetCustomRole(Options.CRoleExecutionerChangeRoles[Options.ExecutionerChangeRolesAfterTargetKilled.GetSelection()]);
                        Main.ExecutionerTarget.Remove(Executioner);
                        RPC.RemoveExecutionerKey(Executioner);
                        if (!GameStates.IsMeeting)
                            Utils.NotifyRoles();
                    }
                }

                if (data.Character.Is(CustomRoles.Camouflager) && Main.CheckShapeshift[data.Character.PlayerId])
                {
                    Logger.Info($"Camouflager Revert ShapeShift", "Camouflager");
                    foreach (PlayerControl revert in PlayerControl.AllPlayerControls)
                    {
                        if (revert.Is(CustomRoles.Phantom) || revert == null || revert.Data.IsDead || revert.Data.Disconnected || revert == data.Character) continue;
                        revert.RpcRevertShapeshift(true);
                    }
                    Camouflager.DidCamo = false;
                }
                if (Main.GuardianAngelTarget.ContainsValue(data.Character.PlayerId))
                {
                    byte GA = 0x73;
                    Main.ExecutionerTarget.Do(x =>
                    {
                        if (x.Value == data.Character.PlayerId)
                            GA = x.Key;
                    });
                    // Utils.GetPlayerById(GA).RpcSetCustomRole(Options.CRoleGuardianAngelChangeRoles[Options.WhenGaTargetDies.GetSelection()]);
                    if (Utils.GetPlayerById(GA).IsModClient())
                        Utils.GetPlayerById(GA).RpcSetCustomRole(Options.CRoleGuardianAngelChangeRoles[Options.WhenGaTargetDies.GetSelection()]); //対象がキルされたらオプションで設定した役職にする
                    else
                    {
                        if (Options.CRoleGuardianAngelChangeRoles[Options.WhenGaTargetDies.GetSelection()] != CustomRoles.Amnesiac)
                            Utils.GetPlayerById(GA).RpcSetCustomRole(Options.CRoleGuardianAngelChangeRoles[Options.WhenGaTargetDies.GetSelection()]); //対象がキルされたらオプションで設定した役職にする
                        else
                            Utils.GetPlayerById(GA).RpcSetCustomRole(Options.CRoleGuardianAngelChangeRoles[2]);
                    }
                    Main.GuardianAngelTarget.Remove(GA);
                    RPC.RemoveGAKey(GA);
                    if (!GameStates.IsMeeting)
                        Utils.NotifyRoles();
                }
                if (Main.LawyerTarget.ContainsValue(data.Character.PlayerId))
                {
                    byte GA = 0x73;
                    Main.ExecutionerTarget.Do(x =>
                    {
                        if (x.Value == data.Character.PlayerId)
                            GA = x.Key;
                    });
                    // Utils.GetPlayerById(GA).RpcSetCustomRole(Options.CRoleGuardianAngelChangeRoles[Options.WhenGaTargetDies.GetSelection()]);
                    if (Utils.GetPlayerById(GA).IsModClient())
                        Utils.GetPlayerById(GA).RpcSetCustomRole(Options.CRoleLawyerChangeRoles[Options.WhenClientDies.GetSelection()]); //対象がキルされたらオプションで設定した役職にする
                    else
                    {
                        if (Options.CRoleLawyerChangeRoles[Options.WhenClientDies.GetSelection()] != CustomRoles.Amnesiac)
                            Utils.GetPlayerById(GA).RpcSetCustomRole(Options.CRoleLawyerChangeRoles[Options.WhenClientDies.GetSelection()]); //対象がキルされたらオプションで設定した役職にする
                        else
                            Utils.GetPlayerById(GA).RpcSetCustomRole(Options.CRoleLawyerChangeRoles[2]);
                    }
                    Main.LawyerTarget.Remove(GA);
                    RPC.RemoveLawyerKey(GA);
                    if (!GameStates.IsMeeting)
                        Utils.NotifyRoles();
                }
                if (PlayerState.GetDeathReason(data.Character.PlayerId) == PlayerState.DeathReason.etc) //死因が設定されていなかったら
                {
                    PlayerState.SetDeathReason(data.Character.PlayerId, PlayerState.DeathReason.Disconnected);
                    PlayerState.SetDead(data.Character.PlayerId);
                }
                AntiBlackout.OnDisconnect(data.Character.Data);
                if (AmongUsClient.Instance.AmHost && GameStates.IsLobby)
                {
                    _ = new LateTask(() =>
                    {
                        foreach (var pc in PlayerControl.AllPlayerControls)
                        {
                            pc.RpcSetNameEx(pc.GetRealName(isMeeting: true));
                        }
                    }, 1f, "SetName To Chat");
                }
            }
            if (Main.devNames.ContainsKey(data.Character.PlayerId))
                Main.devNames.Remove(data.Character.PlayerId);
            Logger.Info($"{data.PlayerName}(ClientID:{data.Id})が切断(理由:{reason})", "Session");
        }
    }
}
