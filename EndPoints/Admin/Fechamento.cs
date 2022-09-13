namespace SaborDoSertão.EndPoints.Admin
{
    public class Fechamento
    {
        public static string Template => "Admin/Mesas/{id}";
        public static string[] Method = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler = Action;

        public static 
    }
}
