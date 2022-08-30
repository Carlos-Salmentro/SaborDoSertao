namespace SaborDoSertão.EndPoints.Mesas
{
    public class MesaGetAll
    {
        public string Template => "/Mesas";
        public string[] Methods = new string[] { HttpMethods.Get.ToString() };
        public IResult Handler => Action;

        public static IResult Action()
        {

        }
    }
}
