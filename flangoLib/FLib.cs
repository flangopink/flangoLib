using System;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
using System.Xml;
using System.Text;

namespace flangoLib
{
    /// <summary>
    /// A library of various methods and functions for SQL and other stuff.
    /// <para>by flangopink</para>
    /// </summary>
    public class FLib
    {
        /// <summary>
        /// Prints out a meesage into debug console.
        /// </summary>
        public static void Print(string? message)
        {
            Debug.WriteLine(message);
        }

        /// <summary>
        /// Рандомное имя (0 - мужское, 1 - женское).
        /// </summary>
        public static string GenerateFirstName(int gender)
        {
            Random r = new();

            var fns_m = new List<string>
            {
                "Александр", "Алексей", "Андрей", "Артем", "Виктор", "Даниил", "Дмитрий",
                "Егор", "Илья", "Кирилл", "Максим", "Марк", "Михаил", "Роман", "Степан",
                "Тимофей", "Ярослав", "Иван", "Никита", "Сергей", "Василий", "Владимир"
            };
            var fns_f = new List<string>
            {
                "Анастасия", "Мария", "Дарья", "Анна", "Елизавета", "Полина", "Виктория",
                "Екатерина", "Софья", "Александра", "Евгения", "Алиса", "Ольга", "Татьяна",
                "Наталья", "Светлана", "Алёна", "Маргарита", "Варвара", "Елена", "Василиса"
            };

            if (gender == 0)
            {
                int i = r.Next(fns_m.Count);
                return fns_m[i];
            }
            else
            {
                int i = r.Next(fns_f.Count);
                return fns_f[i];
            }
        }

        /// <summary>
        /// Рандомная фамилия (0 - мужская, 1 - женская).
        /// </summary>
        public static string GenerateLastName(int gender)
        {
            Random r = new();

            var lns = new List<string>
            {
                "Иванов", "Смирнов", "Кузнецов", "Петров", "Соколов", "Попов", "Лебедев",
                "Козлов", "Новиков", "Морозов", "Волков", "Соловьёв", "Васильев", "Зайцев",
                "Павлов", "Семёнов", "Голубев", "Богданов", "Воробьёв", "Фёдоров", "Михайлов",
                "Беляев", "Тарасов", "Белов", "Орлов", "Макаров", "Ковалёв", "Романов", "Щукин"
            };

            if (gender == 0)
            {
                int i = r.Next(lns.Count);
                return lns[i];
            }
            else
            {
                int i = r.Next(lns.Count);
                return lns[i] + "а";
            }
        }

        /// <summary>
        /// Рандомное отчество (0 - мужское, 1 - женское).
        /// </summary>
        public static string GenerateMiddleName(int gender)
        {
            Random r = new();

            var mns_m = new List<string>
            {
                "Александрович", "Алексеевич", "Андреевич", "Викторович", "Даниилович", "Дмитриевич",
                "Егорович", "Ильич", "Кириллович", "Максимович", "Маркович", "Михайлович", "Романович", "Степанович",
                "Тимофеевич", "Ярославович", "Иванович", "Никитич", "Сергеевич", "Васильевич", "Владимирович"
            };
            var mns_f = new List<string>
            {
                "Александровна", "Алексеевна", "Андреевна", "Викторовна", "Данииловна", "Дмитриевна",
                "Егоровна", "Ильична", "Кирилловна", "Максимовна", "Марковна", "Михайловна", "Романовна", "Степановна",
                "Тимофеевна", "Ярославовна", "Ивановна", "Никитична", "Сергеевна", "Васильевна", "Владимировна"
            };

            if (gender == 0)
            {
                int i = r.Next(mns_m.Count);
                return mns_m[i];
            }
            else
            {
                int i = r.Next(mns_f.Count);
                return mns_f[i];
            }
        }

        /// <summary>
        /// Рандомные инициалы (например, "И. И.").
        /// </summary>
        public static string GenerateInitials()
        {
            Random r = new();

            var inits = new List<string>
            {
                "А", "Б", "В", "Г", "Д", "Е", "З", "И", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "Ф", "Э", "Ю", "Я"
            };

            return $"{inits[r.Next(inits.Count)]}. {inits[r.Next(inits.Count)]}.";
        }

        /// <summary>
        /// Рандомный адрес (улица, дом, квартира).
        /// </summary>
        public static string GenerateAddress()
        {
            Random r = new();

            var addr = new List<string>
            {
                "Центральная", "Молодёжная", "Лесная", "Садовая", "Советская", "Пушкина", "Ленина", "Щербакова", "Новая",
                "Набережная", "Белинского", "Заречная", "Зелёная", "Красная", "Мира", "Октябрьская", "Гагарина", "Солнечная",
                "Комсомольская", "Первомайская", "Северная", "Южная", "Кирова", "Восточная", "Нагорная", "Рабочая", "Космонавтов",
                "Дружбы", "Горького", "Парковая", "Спортивная", "Красноармейская", "Труда", "8 Марта", "Карла Маркса", "Свободы",
                "Сосновая", "Маяковского", "Фрунзе", "Гоголя", "Горная", "1 Мая", "Чехова", "Машиностроителей", "Светлая", "Майская"
            };

            int i = r.Next(addr.Count);

            return $"ул. {addr[i]}, д. {r.Next(0, 301)}, кв. {r.Next(0, 301)}";
        }

        /// <summary>
        /// Рандомный номер телефона.
        /// </summary>
        public static string GeneratePhoneNumber()
        {
            Random r = new();

            return $"+7{r.Next(0, 10)}{r.Next(0, 10)}{r.Next(0, 10)}{r.Next(0, 10)}{r.Next(0, 10)}" +
                     $"{r.Next(0, 10)}{r.Next(0, 10)}{r.Next(0, 10)}{r.Next(0, 10)}{r.Next(0, 10)}";
        }

        /// <summary>
        /// Рандомный паспорт (пока только Екатеринбург).
        /// </summary>
        public static string GeneratePassport()
        {
            Random r = new();

            var p1 = new List<string>
            {
                "Свердловской"
            };
            var p2 = new List<string>
            {
                "Верх-Исетском", "Железнодорожном", "Кировском", "Октябрьском", "Орджоникидзевском", "Ленинском", "Чкаловском"
            };
            var p3 = new List<string>
            {
                "Екатеринбурга"
            };


            return $"{r.Next(0, 10)}{r.Next(0, 10)}{r.Next(0, 10)}{r.Next(0, 10)} " +
                   $"{r.Next(0, 10)}{r.Next(0, 10)}{r.Next(0, 10)}{r.Next(0, 10)}{r.Next(0, 10)}{r.Next(0, 10)}" +
                   $" отделом УФМС России по {p1[r.Next(p1.Count)]} обл. в {p2[r.Next(p2.Count)]} р-не г. {p3[r.Next(p3.Count)]}";
        }

        /// <summary>
        /// Список всех доступных типов столбцов.
        /// <para>"ФИО", "Ф_Инициалы", "Инициалы_Ф", "Имя", "Фамилия", "Отчество", "Адрес", "Телефон", "Паспорт"</para>
        /// </summary>
        public static readonly List<string> TypesList = new() { "ФИО", "Ф_Иниц", "Иниц_Ф", "Имя", "Фамилия", "Отчество", "Адрес", "Телефон", "Паспорт" };

        /// <summary>
        /// Словарь всех доступных типов столбцов.
        /// <para>
        ///     [1] = "ФИО", [2] = "Ф_Инициалы", [3] = "Инициалы_Ф", [4] = "Имя",
        ///     [5] = "Фамилия", [6] = "Отчество", [7] = "Адрес", [8] = "Телефон",
        ///     [9] = "Паспорт" 
        /// </para>
        /// </summary>
        public static readonly Dictionary<int, string> TypesDict = new()
        { [1] = "ФИО", [2] = "Ф_Иниц", [3] = "Иниц_Ф", [4] = "Имя",
          [5] = "Фамилия", [6] = "Отчество", [7] = "Адрес", [8] = "Телефон",
          [9] = "Паспорт" 
        };

        /// <summary>
        /// Генерирует текст запроса SQL типа <c>insert into [Table] values (v1, v2, ...)</c> с рандомными данными.
        /// </summary>
        /// <remarks>
        /// ---------- Параметры ----------
        /// <para> ★ <see langword="List&lt;string&gt;"/> <paramref name="types"/> - Список типов вывода для каждого столбца соответственно. (см. <see cref="TypesList"/>)</para>
        /// <para> (o) <see langword="int"/> <paramref name="count"/> - Количество строк. (def: 1)</para>
        /// <para> (o) <see langword="string"/> <paramref name="tableName"/> - Имя таблицы. (def и при "": &lt;Table Name&gt;)</para>
        /// </remarks>
        public static string GenerateInsertQuery(List<string> types, int count = 1, string tableName = "<Table Name>")
        {
            string query = "";

            if (tableName == "") tableName = "<Table Name>"; //Autofill to avoid confusion

            query += $"insert into {tableName} values ";

            for (int i = 0; i < count; i++)
            {
                query += '(';

                int c = 0;
                foreach (string str in types)
                {
                    if (str != "") c++;
                    else continue;
                }

                Random r = new();
                int g = r.Next(0, 2);

                for (int j = 0; j < c; j++)
                {
                    if (j > 0 && j < c) query += ",";
                    switch (types[j])
                    {
                        case "ФИО":
                            query += $"'{GenerateLastName(g)} {GenerateFirstName(g)} {GenerateMiddleName(g)}'";
                            continue;

                        case "Ф_Иниц":
                            query += $"'{GenerateLastName(g)} {GenerateInitials()}'";
                            continue;

                        case "Иниц_Ф":
                            query += $"'{GenerateInitials()} {GenerateLastName(g)}'";
                            continue;

                        case "Фамилия":
                            query += $"'{GenerateLastName(g)}'";
                            continue;

                        case "Имя":
                            query += $"'{GenerateFirstName(g)}'";
                            continue;

                        case "Отчество":
                            query += $"'{GenerateMiddleName(g)}'";
                            continue;

                        case "Адрес":
                            query += $"'{GenerateAddress()}'";
                            continue;

                        case "Телефон":
                            query += $"'{GeneratePhoneNumber()}'";
                            continue;

                        case "Паспорт":
                            query += $"'{GeneratePassport()}'";
                            continue;

                        default:
                            Print(nameof(FLib) + ": Указан неверный тип столбца в GenerateInsertQuery()");
                            continue;
                    }
                }
                if (i + 1 < count) query += "),";
                else query += ");";
            }
            return query;
        }

        /// <summary>
        /// Посылает запрос SQL в указанную базу данных.
        /// </summary>
        /// <remarks>
        /// ---------- Параметры ----------
        /// <para> ★ <see langword="string"/> <paramref name="server"/> - Локация сервера SQL. (например, .\SQLEXPRESS)</para>
        /// <para> ★ <see langword="string"/> <paramref name="database"/> - Название базы данных.</para>
        /// <para> ★ <see langword="string"/> <paramref name="query"/> - Запрос SQL. (например, <c>select * from TestTable</c>)</para>
        /// </remarks>
        public static void ExecuteQuery(string server, string database, string query)
        {
            string connetionString = $"Data Source={server};Initial Catalog={database};Integrated Security=SSPI;Encrypt=True;TrustServerCertificate=True;";
            SqlConnection connection;
            SqlCommand command;
            string sql = query;

            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                Print("Successfully queried!");
            }
            catch (Exception ex)
            {
                Print("Can't open connection!\n\n" + ex);
                throw;
            }
        }

        /// <summary>
        /// Выводит словарь с курсом валюты из Центробанка.
        /// </summary>
        public static Dictionary<string, string> GetCurrencyRates()
        {
            Dictionary<string, string> dict = new();

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            XmlReaderSettings settings = new();
            settings.IgnoreComments = true;
            settings.IgnoreProcessingInstructions = true;
            settings.IgnoreWhitespace = true;
            XmlUrlResolver resolver = new();
            resolver.Credentials = System.Net.CredentialCache.DefaultCredentials;
            settings.XmlResolver = resolver;

            XmlReader reader = XmlReader.Create("http://www.cbr.ru/scripts/XML_daily.asp", settings);

            string[] row = { "", "" };

            XmlDocument currentXMLDocument = new(   );
            XmlNode? xmlNode;

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "Valute")
                        {
                            if (reader.HasAttributes)
                            {
                                while (reader.MoveToNextAttribute())
                                {
                                    if (reader.Name == "ID")
                                    {
                                        reader.MoveToElement();
                                        currentXMLDocument.LoadXml(reader.ReadOuterXml());

                                        xmlNode = currentXMLDocument.SelectSingleNode("Valute/Name");
                                        row[0] = xmlNode!.InnerText;

                                        xmlNode = currentXMLDocument.SelectSingleNode("Valute/Value");
                                        row[1] = xmlNode!.InnerText;

                                        dict.Add(row[0], row[1].Replace(',','.'));
                                    }
                                }
                            }
                        }
                        break;
                }
            }

            return dict;
        }

        /// <summary>
        /// (Без ID) Генерирует текст запроса SQL типа <c>insert into [Table] values (currency, value);</c> с данными о курсе валют из Центробанка.
        /// </summary>
        /// <remarks>
        /// ⚠⚠ Примечание: Использование этого запроса очистит таблицу перед заполнением её новыми данными! ⚠⚠
        /// <para>---------- Параметры ----------</para>
        /// <para> (o) <see langword="string"/> <paramref name="tableName"/> - Имя таблицы. (def и при "": &lt;Table Name&gt;)</para>
        /// </remarks>
        public static string GenerateCurrencyRateInsertQuery(string tableName = "<TableName>")
        {
            if (tableName == "") tableName = "<TableName>";

            string sql = $"truncate table {tableName} insert into {tableName} values ";

            foreach (KeyValuePair<string, string> kvp in GetCurrencyRates())
            {
                sql += $"('{kvp.Key}', {kvp.Value}),";
            }

            sql = sql.TrimEnd(',')+';';

            return sql;
        }

        /// <summary>
        /// (С ID) Генерирует текст запроса SQL типа <c>insert into [Table] values (currency, value);</c> с данными о курсе валют из Центробанка.
        /// </summary>
        /// <remarks>
        /// ⚠⚠ Примечание: Использование этого запроса очистит таблицу перед заполнением её новыми данными! ⚠⚠
        /// <para>---------- Параметры ----------</para>
        /// <para> ★ <see langword="string"/> <paramref name="column_id"/> - Название столбца ID (первичного ключа типа <see langword="int"/>) (например, id, money_id).</para>
        /// <para> ★ <see langword="string"/> <paramref name="column1"/> - Название первого столбца. (например, Валюта, Название, Currency)</para>
        /// <para> ★ <see langword="string"/> <paramref name="column2"/> - Название второго столбца. (например, Курс, Стоимость, Value)</para>
        /// <para> (o) <see langword="string"/> <paramref name="tableName"/> - Имя таблицы. (def и при "": &lt;Table Name&gt;)</para>
        /// </remarks>
        public static string GenerateCurrencyRateInsertQuery_WithID(string column_id, string column1, string column2, string tableName = "<TableName>")
        {
            if (tableName == "") tableName = "<TableName>";

            string sql = $"SET IDENTITY_INSERT {tableName} ON; truncate table {tableName} insert into {tableName}" +
                $" ({column_id}, {column1}, {column2}) values ";

            int i = 0;

            foreach (KeyValuePair<string, string> kvp in GetCurrencyRates())
            {
                sql += $"({++i}, '{kvp.Key}', {kvp.Value}),";
            }

            sql = sql.TrimEnd(',') + $"; SET IDENTITY_INSERT {tableName} OFF;";

            return sql;
        }
    }
}