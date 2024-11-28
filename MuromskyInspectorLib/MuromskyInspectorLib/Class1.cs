namespace MuromskyInspectorLib
{
    public class FunctionInsp
    {
        private string mainInspector = "Васильев Василий Иванович"; 
        private string inspectionName = "Автоинспекция г. Чита"; //поля содержащие название автоинспекции и ФИО главного инспектора
        private List<string> workers = new List<string> 
        {
            "Иванов И.И.",
            "Зиронов Т.А.",
            "Миронов А.В.",  //cписок сотрудников автоинспекции
            "Васильев В.И."
        };

        public string GetInspector() //получаем ФИО главного инспектора в виде string
        {
            return mainInspector; //возвращаем ФИО главного инспектора
        }

        public string GetCarInspection() //получаем название автоинспекции
        {
            return inspectionName; //возвращаем название
        }

        public bool SetInspector(string fullname) //получаем нового инспектора
        {
            if (workers.Contains(fullname)) //есть ли сотрудник в списке
            {
                mainInspector = fullname; //ставит нового испектора если да
                return true;
            }
            return false;
        }

        public string GenerateNumber(string symbol, int number, string code) //получаем данные гос номера
        {
            if (string.IsNullOrEmpty(symbol) || char.IsLower(symbol[0]) || !char.IsLetter(symbol[0])) //прроверка корректности введенных данных
            {
                throw new ArgumentException("Символ должен состоять из одной заглавной буквы.");
            }
            return $"{symbol.ToUpper()}{number}_{code}"; //формируем госномер
        }

        public List<string> GetWorker() //получаем список сотрудников
        {
            return new List<string>(workers); //возвращаем список
        }

        public void AddWorker(string fullname) //получаем ФИО сотрудника
        {
            if (!workers.Contains(fullname)) //проверка есть сотрудник в списке
            {
                workers.Add(fullname); //добавляем нового сотрудника если его нет в списке
            }
        }
    }
}
