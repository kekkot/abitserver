using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiturientServer.DAL
{
    public class DbInitializer
    {
        private DatabaseContext context;
        public DbInitializer(DatabaseContext context)
        {
            this.context = context;
        }

        


        public void Initialize()
        {
            if(!context.Regions.Any())
            {
                context.Regions.AddRange(GetRegions());
            }
            if (!context.Countries.Any())
            {
                context.Countries.AddRange(GetCountries());
            }
            if (!context.Privileges.Any())
            {
                context.Privileges.AddRange(GetPrivileges());
            }
            if (!context.EducationalInstitutions.Any())
            {
                context.EducationalInstitutions.AddRange(GetEducationalInstitutions());
            }
            if (!context.IndividualAchievements.Any())
            {
                context.IndividualAchievements.AddRange(GetIndividualAchievements());
            }
            if (!context.VerificationDocuments.Any())
            {
                context.VerificationDocuments.AddRange(GetVerificationDocuments());
            }
            if (!context.ExamGrounds.Any())
            {
                context.ExamGrounds.AddRange(GetExamGrounds());
            }
            if (!context.NoExams.Any())
            {
                context.NoExams.AddRange(GetNoExams());
            }
            if (!context.Statuses.Any())
            {
                context.Statuses.AddRange(GetStatuses());
            }
            if (!context.Languages.Any())
            {
                context.Languages.AddRange(GetLanguages());
            }
            if (!context.EducationalDocuments.Any())
            {
                context.EducationalDocuments.AddRange(GetEducationalDocuments());
            }
            //if (!context.Departments.Any())
            //{
            //    context.Departments.AddRange(GetDepartments());
            //}
            if (!context.Roles.Any())
            {
                context.Roles.AddRange(GetIdentityRoles());
            }
            if (!context.FormOfEducations.Any())
            {
                context.FormOfEducations.AddRange(GetFormOfEducations());
            }
            if (!context.ExamForms.Any())
            {
                context.ExamForms.AddRange(GetExamForms());
            }
            if (!context.Contests.Any())
            {
                context.Contests.AddRange(GetContests());
            }
            if (!context.EducationLevels.Any())
            {
                context.EducationLevels.AddRange(GetEducationLevels());
            }

            context.SaveChanges();
        }


        private EducationLevel[] GetEducationLevels()
        {
            return new EducationLevel[]
            {
                new EducationLevel { Code = "б", Name = "Бакалавриат"},
                new EducationLevel { Code = "м", Name = "Магистратура"},
                new EducationLevel { Code = "с", Name = "Специалитет"},
            };
        }

        private Contest[] GetContests()
        {
            return new Contest[]
            {
                new Contest{ Code = "б", Name = "без экзаменов", Order = 3},
                new Contest{ Code = "л", Name = "особое право", Order = 1},
                new Contest{ Code = "о", Name = "общий", Order = 4},
                new Contest{ Code = "ц", Name = "целевой прием", Order = 2}
            };
        }

        private ExamForm[] GetExamForms()
        {
            return new ExamForm[]
            {
                new ExamForm{Id = 1, Name = "ЕГЭ"},
                new ExamForm{Id = 2, Name = "тестирование"},
                new ExamForm{Id = 3, Name = "творческий конкурс"}
            };
        }

        private FormOfEducation[] GetFormOfEducations()
        {
            return new FormOfEducation[]
            {
                new FormOfEducation{ Code = "ДК", Name = "Очная коммерческая", Order = 2, Description = "Очная по договорам об оплате образовательных услуг"},
                new FormOfEducation{ Code = "ДО", Name = "Очная госбюджетная", Order = 1, Description = "Очная за счет бюджетных ассигнований федерального бюджета"},
                new FormOfEducation{ Code = "ЗК", Name = "Заочная коммерческая", Order = 4, Description = "Заочная по договорам об оплате образовательных услуг"},
                new FormOfEducation{ Code = "ЗО", Name = "Заочная госбюжетная ", Order = 3, Description = "Заочная за счет бюджетных ассигнований федерального бюджета"},
                new FormOfEducation{ Code = "ОЗК", Name = "Очно-заочная коммерческая", Order = 6, Description = "Очно-заочная по договорам об оплате образовательных услуг"},
                new FormOfEducation{ Code = "ОЗО", Name = "Очно-заочная госбюджетная", Order = 5, Description = "Очно-заочная за счет бюджетных ассигнований федерального бюджета"}
            };
        }

        private IdentityRole[] GetIdentityRoles()
        {
            return new IdentityRole[]
            {
                new IdentityRole("Client") { NormalizedName = "CLIENT"},
                new IdentityRole("Admin") { NormalizedName = "ADMIN"},
                new IdentityRole("Department") { NormalizedName = "DEPARTMENT"},
                new IdentityRole("Abiturient") { NormalizedName = "ABITURIENT"},
            };
        }

        //private Department[] GetDepartments()
        //{
        //    return new Department[]
        //    {
        //        new Department{ Code = "АБП", Name = "Агротехнологическая академия ", Order = 2},
        //        new Department{ Code = "АСА", Name = "Академия строительства и архитектуры", Order = 3},
        //        new Department{ Code = "ИМК", Name = "Институт медиакоммуникаций, медиатехнологий и дизайна", Order = 8},
        //        new Department{ Code = "ИФИ", Name = "Институт филологии", Order = 7},
        //        new Department{ Code = "ИЭУ", Name = "Институт экономики и управления", Order = 4},
        //        new Department{ Code = "МА", Name = "Медицинская академия", Order = 5},
        //        new Department{ Code = "ТА", Name = "Таврическая академия", Order = 1},
        //        new Department{ Code = "ФТИ", Name = "Физико-технический институт", Order = 6}
        //    };
        //}

        private EducationalDocument[] GetEducationalDocuments()
        {
            return new EducationalDocument[]
            {
                new EducationalDocument {Code = "а", Name = "аттестат о среднем (полном) общем образовании", Description = ""},
                new EducationalDocument {Code = "дв", Name = "диплом о высшем профессиональном образовании", Description = ""},
                new EducationalDocument {Code = "дс", Name = "диплом о среднем профессиональном образовании", Description = ""},
                new EducationalDocument {Code = "дп", Name = "диплом о начальном профессиональном обаразовании", Description = ""},
            };
        }

        private Language[] GetLanguages()
        {
            return new Language[]
            {
                new Language{Id = 1, Code = "EN", Name = "Английский"},
                new Language{Id = 2, Code = "FR", Name = "Французский"},
                new Language{Id = 3, Code = "DE", Name = "Немецкий"},
                new Language{Id = 4, Code = "", Name = "Иной"},
            };
        }

        private Status[] GetStatuses()
        {
            return new Status[]
            {
                new Status{Id = 1, Name = "Проверка"},
                new Status{Id = 2, Name = "Недостаточно документов"},
                new Status{Id = 3, Name = "Допущен к конкурсу"},
                new Status{Id = 4, Name = "Зачислен"},
                new Status{Id = 5, Name = "Документы отозваны"},
                new Status{Id = 6, Name = "Отклонено"},
            };
        }

        private NoExam[] GetNoExams()
        {
            return new NoExam[]
            {
                new NoExam{ Code = "в", Name = "всероссийская олимпиада", Description = "Победители и призеры всероссийской олимпиады"},
                new NoExam{ Code = "к", Name = "члены команд РФ", Description = "Члены сборных команд Российской Федерации"},
                new NoExam{ Code = "ои", Name = "призеры олимп. игр", Description = "Чемпионы и призеры Олимпийских игр"},
                new NoExam{ Code = "ш", Name = "призеры олимпиад школьников", Description = "Победитель и призер олимпиад школьников"}
            };
        }

        private ExamGround[] GetExamGrounds()
        {
            return new ExamGround[]
            {
                new ExamGround{Code = "о", Name = "призер олимпиад школьников", Description = "Победитель и призер олимпиад школьников", Score = 100},
                new ExamGround{Code = "с", Name = "призер в обл. спорта", Description = "Чемпион и призер в области спорта", Score = 100}
            };
        }

        private VerificationDocument[] GetVerificationDocuments()
        {
            return new VerificationDocument[]
            {
                new VerificationDocument{ Id = 1, Name = "Паспорт гражданина РФ", Order = 1, Description = ""},
                new VerificationDocument{ Id = 2, Name = "Заграничный паспорт гражданина РФ", Order = 2, Description = ""},
                new VerificationDocument{ Id = 3, Name = "Паспорт гражданина иностранного государства", Order = 3, Description = ""},
                new VerificationDocument{ Id = 4, Name = "Свидетельство о рождении", Order = 4, Description = ""},
                new VerificationDocument{ Id = 5, Name = "Военный билет", Order = 5, Description = ""},
                new VerificationDocument{ Id = 6, Name = "Дипломатический паспорт гражданина РФ", Order = 6, Description = ""},
                new VerificationDocument{ Id = 7, Name = "Паспорт моряка", Order = 7, Description = ""},
                new VerificationDocument{ Id = 8, Name = "Иностранное свидетельство о рождении", Order = 8, Description = "Cвидетельство о рождении, выданное уполномоченным органом иностранного государства"},
                new VerificationDocument{ Id = 9, Name = "Иной документ", Order = 9, Description = "Иной документ, удостоверяющий личность"},
                new VerificationDocument{ Id = 10, Name = "Временное удостоверение личности гражданина РФ", Order = 10, Description = ""},
                new VerificationDocument{ Id = 11, Name = "Вид на жительство", Order = 11, Description = ""},
                new VerificationDocument{ Id = 12, Name = "Пластиковая карта гражданина Российской Федерации", Order = 12, Description = "Удостоверение личности гражданина Российской Федерации в виде пластиковой карты"},
                new VerificationDocument{ Id = 13, Name = "Служебный паспорт", Order = 13, Description = ""},
                new VerificationDocument{ Id = 14, Name = "Удостоверение личности военнослужащего", Order = 14, Description = ""},
                new VerificationDocument{ Id = 15, Name = "Разрешение на временное проживание", Order = 15, Description = ""},
                new VerificationDocument{ Id = 16, Name = "Удостоверение беженца", Order = 16, Description = ""},
                new VerificationDocument{ Id = 17, Name = "Свидетельство ходатайства беженца", Order = 17, Description = "Свидетельство о рассмотрении ходатайства о признании гражданина беженцем"}
            };
        }

        private IndividualAchievement[] GetIndividualAchievements()
        {
            return new IndividualAchievement[]
            {
                new IndividualAchievement{ Code = "зм19", Name = "Аттестат с отличием", AdditionalScore = 10, Order = 1},
                new IndividualAchievement{ Code = "дм19", Name = "Диплом с отличием", AdditionalScore = 10, Order = 2},
                new IndividualAchievement{ Code = "гто19", Name = "Удостоверениче о сдаче ГТО", AdditionalScore = 10, Order = 3},
                new IndividualAchievement{ Code = "пм19", Name = "Грамота МАН (победитель)", AdditionalScore = 10, Order = 4},
                new IndividualAchievement{ Code = "по19", Name = "Грамота победителя олимпиады", AdditionalScore = 10, Order = 5},
                new IndividualAchievement{ Code = "с19", Name = "Диплом победителя в области спорта", AdditionalScore = 10, Order = 6},
                new IndividualAchievement{ Code = "прм19", Name = "Грамота МАН (призер)", AdditionalScore = 10, Order = 7},
                new IndividualAchievement{ Code = "про19", Name = "Грамота призера олимпиады", AdditionalScore = 10, Order = 8},
                new IndividualAchievement{ Code = "пк19", Name = "Победитель олимпиады КФУ", AdditionalScore = 10, Order = 9}
            };
        }

        private EducationalInstitution[] GetEducationalInstitutions()
        {
            return new EducationalInstitution[]
            {
                new EducationalInstitution{ Code = "вуз", Name = "вуз", Description = "ВУЗ"},
                new EducationalInstitution{ Code = "пту", Name = "колледж, пту", Description = "ПТУ, колледж или техникум"},
                new EducationalInstitution{ Code = "сош", Name = "средняя школа", Description = "средняя общеобразовательная школа"},
            };
        }


        private Privilege[] GetPrivileges()
        {
            return new Privilege[]
            {
                new Privilege{ Code = "c1", Name = "сирота(иной документ)", Order = 3},
                new Privilege{ Code = "в", Name = "ветеран", Order = 8},
                new Privilege{ Code = "и1", Name = "инвалид c детства", Order = 5},
                new Privilege{ Code = "и2", Name = "ребенок-инвалид", Order = 4},
                new Privilege{ Code = "и3", Name = "инвалид 1 группы", Order = 6},
                new Privilege{ Code = "и4", Name = "инвалид 2 группы", Order = 7},
                new Privilege{ Code = "с", Name = "сирота(справка из органов соцзащиты)", Order = 1},
                new Privilege{ Code = "с2", Name = "сирота(свидетельство о смерти)", Order = 2}
            };
        }

        private Country[] GetCountries()
        {
            return new Country[]
            {
                new Country{ Code = 1, Name = "Российская Федерация", Order = 0},
                new Country{ Code = 3, Name = "Алжир", Order = 25},
                new Country{ Code = 12, Name = "Бангладеш", Order = 27},
                new Country{ Code = 13, Name = "Армения", Order = 5},
                new Country{ Code = 29, Name = "Беларусь", Order = 15},
                new Country{ Code = 31, Name = "Камерун", Order = 28},
                new Country{ Code = 32, Name = "Канада", Order = 37},
                new Country{ Code = 36, Name = "Шри-Ланка", Order = 20},
                new Country{ Code = 39, Name = "Китай", Order = 6},
                new Country{ Code = 45, Name = "Конго", Order = 13},
                new Country{ Code = 53, Name = "Бенин", Order = 18},
                new Country{ Code = 59, Name = "Эфиопия", Order = 22},
                new Country{ Code = 75, Name = "Германия", Order = 42},
                new Country{ Code = 76, Name = "Гана", Order = 19},
                new Country{ Code = 78, Name = "Греция", Order = 30},
                new Country{ Code = 92, Name = "Индия", Order = 7},
                new Country{ Code = 102, Name = "Казахстан", Order = 14},
                new Country{ Code = 103, Name = "Иордания", Order = 33},
                new Country{ Code = 104, Name = "Кения", Order = 9},
                new Country{ Code = 106, Name = "Республика Корея", Order = 34},
                new Country{ Code = 108, Name = "Киргизия", Order = 24},
                new Country{ Code = 110, Name = "Ливан", Order = 45},
                new Country{ Code = 120, Name = "Малайзия", Order = 8},
                new Country{ Code = 130, Name = "Молдова", Order = 16},
                new Country{ Code = 132, Name = "Марокко", Order = 35},
                new Country{ Code = 144, Name = "Нигерия", Order = 12},
                new Country{ Code = 153, Name = "Пакистан", Order = 36},
                new Country{ Code = 186, Name = "Зимбабве", Order = 21},
                new Country{ Code = 195, Name = "Сирия", Order = 40},
                new Country{ Code = 196, Name = "Таджикистан", Order = 32},
                new Country{ Code = 204, Name = "Турция", Order = 41},
                new Country{ Code = 205, Name = "Туркменистан", Order = 3},
                new Country{ Code = 208, Name = "Уганда", Order = 23},
                new Country{ Code = 209, Name = "Украина", Order = 1},
                new Country{ Code = 210, Name = "Египет", Order = 26},
                new Country{ Code = 220, Name = "Узбекистан", Order = 2},
                new Country{ Code = 221, Name = "Йемен", Order = 29},
                new Country{ Code = 222, Name = "Замбия", Order = 39},
                new Country{ Code = 223, Name = "Абхазия", Order = 17},
                new Country{ Code = 226, Name = "Азербайджан", Order = 4},
                new Country{ Code = 230, Name = "Афганистан", Order = 10},
                new Country{ Code = 233, Name = "Палестина", Order = 11},
                new Country{ Code = 237, Name = "Без гражданства", Order = 31}
            };
        }

        private Region[] GetRegions()
        {
            return new Region[]
                {
                    new Region{ Code = 1, Name = "Республика Адыгея (Адыгея)", Order = 49},
                    new Region{ Code = 2, Name = "Республика Башкортостан", Order = 51},
                    new Region{ Code = 3, Name = "Республика Бурятия", Order = 52},
                    new Region{ Code = 4, Name = "Республика Алтай", Order = 50},
                    new Region{ Code = 5, Name = "Республика Дагестан", Order = 53},
                    new Region{ Code = 6, Name = "Республика Ингушетия", Order = 54},
                    new Region{ Code = 7, Name = "Кабардино-Балкарская Республика", Order = 17},
                    new Region{ Code = 8, Name = "Республика Калмыкия", Order = 55},
                    new Region{ Code = 9, Name = "Карачаево-Черкесская Республика", Order = 21},
                    new Region{ Code = 10, Name = "Республика Карелия", Order = 56},
                    new Region{ Code = 11, Name = "Республика Коми", Order = 57},
                    new Region{ Code = 12, Name = "Республика Марий Эл", Order = 59},
                    new Region{ Code = 13, Name = "Республика Мордовия", Order = 60},
                    new Region{ Code = 14, Name = "Республика Саха (Якутия)", Order = 61},
                    new Region{ Code = 15, Name = "Республика Северная Осетия-Алания", Order = 62},
                    new Region{ Code = 16, Name = "Республика Татарстан (Татарстан)", Order = 63},
                    new Region{ Code = 17, Name = "Республика Тыва", Order = 64},
                    new Region{ Code = 18, Name = "Удмуртская Республика", Order = 80},
                    new Region{ Code = 19, Name = "Республика Хакасия", Order = 65},
                    new Region{ Code = 20, Name = "Чеченская Республика", Order = 85},
                    new Region{ Code = 21, Name = "Чувашская Республика - Чувашия", Order = 86},
                    new Region{ Code = 22, Name = "Алтайский край", Order = 2},
                    new Region{ Code = 23, Name = "Краснодарский край", Order = 25},
                    new Region{ Code = 24, Name = "Красноярский край", Order = 26},
                    new Region{ Code = 25, Name = "Приморский край", Order = 47},
                    new Region{ Code = 26, Name = "Ставропольский край", Order = 74},
                    new Region{ Code = 27, Name = "Хабаровский край", Order = 82},
                    new Region{ Code = 28, Name = "Амурская область", Order = 3},
                    new Region{ Code = 29, Name = "Архангельская область", Order = 4},
                    new Region{ Code = 30, Name = "Астраханская область", Order = 5},
                    new Region{ Code = 31, Name = "Белгородская область", Order = 6},
                    new Region{ Code = 32, Name = "Брянская область", Order = 7},
                    new Region{ Code = 33, Name = "Владимирская область", Order = 8},
                    new Region{ Code = 34, Name = "Волгоградская область", Order = 9},
                    new Region{ Code = 35, Name = "Вологодская область", Order = 10},
                    new Region{ Code = 36, Name = "Воронежская область", Order = 11},
                    new Region{ Code = 37, Name = "Ивановская область", Order = 15},
                    new Region{ Code = 38, Name = "Иркутская область", Order = 16},
                    new Region{ Code = 39, Name = "Калининградская область", Order = 18},
                    new Region{ Code = 40, Name = "Калужская область", Order = 19},
                    new Region{ Code = 41, Name = "Камчатская область", Order = 20},
                    new Region{ Code = 42, Name = "Кемеровская область", Order = 22},
                    new Region{ Code = 43, Name = "Кировская область", Order = 23},
                    new Region{ Code = 44, Name = "Костромская область", Order = 24},
                    new Region{ Code = 45, Name = "Курганская область", Order = 27},
                    new Region{ Code = 46, Name = "Курская область", Order = 28},
                    new Region{ Code = 47, Name = "Ленинградская область", Order = 29},
                    new Region{ Code = 48, Name = "Липецкая область", Order = 30},
                    new Region{ Code = 49, Name = "Магаданская область", Order = 31},
                    new Region{ Code = 50, Name = "Московская область", Order = 33},
                    new Region{ Code = 51, Name = "Мурманская область", Order = 34},
                    new Region{ Code = 52, Name = "Нижегородская область", Order = 37},
                    new Region{ Code = 53, Name = "Новгородская область", Order = 38},
                    new Region{ Code = 54, Name = "Новосибирская область", Order = 39},
                    new Region{ Code = 55, Name = "Омская область", Order = 41},
                    new Region{ Code = 56, Name = "Оренбургская область", Order = 42},
                    new Region{ Code = 57, Name = "Орловская область", Order = 43},
                    new Region{ Code = 58, Name = "Пензенская область", Order = 45},
                    new Region{ Code = 59, Name = "Пермский край", Order = 46},
                    new Region{ Code = 60, Name = "Псковская область", Order = 48},
                    new Region{ Code = 61, Name = "Ростовская область", Order = 66},
                    new Region{ Code = 62, Name = "Рязанская область", Order = 67},
                    new Region{ Code = 63, Name = "Самарская область", Order = 68},
                    new Region{ Code = 64, Name = "Саратовская область", Order = 70},
                    new Region{ Code = 65, Name = "Сахалинская область", Order = 71},
                    new Region{ Code = 66, Name = "Свердловская область", Order = 72},
                    new Region{ Code = 67, Name = "Смоленская область", Order = 73},
                    new Region{ Code = 68, Name = "Тамбовская область", Order = 75},
                    new Region{ Code = 69, Name = "Тверская область", Order = 76},
                    new Region{ Code = 70, Name = "Томская область", Order = 77},
                    new Region{ Code = 71, Name = "Тульская область", Order = 78},
                    new Region{ Code = 72, Name = "Тюменская область", Order = 79},
                    new Region{ Code = 73, Name = "Ульяновская область", Order = 81},
                    new Region{ Code = 74, Name = "Челябинская область", Order = 84},
                    new Region{ Code = 75, Name = "Забайкальский край", Order = 14},
                    new Region{ Code = 76, Name = "Ярославская область", Order = 89},
                    new Region{ Code = 77, Name = "Москва", Order = 32},
                    new Region{ Code = 78, Name = "Санкт-Петербург", Order = 69},
                    new Region{ Code = 79, Name = "Еврейская автономная область", Order = 13},
                    new Region{ Code = 82, Name = "Республика Крым", Order = 0},
                    new Region{ Code = 83, Name = "Ненецкий автономный округ", Order = 36},
                    new Region{ Code = 86, Name = "Ханты-Мансийский автономный округ", Order = 83},
                    new Region{ Code = 87, Name = "Чукотский автономный округ", Order = 87},
                    new Region{ Code = 89, Name = "Ямало-Ненецкий автономный округ", Order = 88},
                    new Region{ Code = 90, Name = "Отсутствует", Order = 44},
                    new Region{ Code = 92, Name = "г. Севастополь", Order = 1},
                    new Region{ Code = 1000, Name = "Не назначено", Order = 35},
                    new Region{ Code = 1001, Name = "Образовательные учреждения, находящиеся за пределами Российской Федерации", Order = 40}
                };
        }
    }
}
