namespace HealthCare_Plus.Utils
{
    internal class RoomUtils
    {
        public static int GetSelectedRoomID(string selectedRoomValue)
        {
            switch (selectedRoomValue)
            {
                case "Комната 1":
                    return 1;
                case "Комната 2":
                    return 2;
                case "Комната 3":
                    return 3;
                case "Комната 4":
                    return 4;
                case "Комната 5":
                    return 5;
                case "Комната 6":
                    return 6;
                case "Комната 7":
                    return 7;
                case "Комната 8":
                    return 8;
                case "Комната 9":
                    return 9;
                case "Комната 10":
                    return 10;
                default:
                    return 0;
            }
        }

        public static string GetSelectedRoomText(int selectedRoomID)
        {
            switch (selectedRoomID)
            {
                case 1:
                    return "Комната 1";
                case 2:
                    return "Комната 2";
                case 3:
                    return "Комната 3";
                case 4:
                    return "Комната 4";
                case 5:
                    return "Комната 5";
                case 6:
                    return "Комната 6";
                case 7:
                    return "Комната 7";
                case 8:
                    return "Комната 8";
                case 9:
                    return "Комната 9";
                case 10:
                    return "Комната 10";
                default:
                    return "Комната 1";
            }
        }
    }
}
