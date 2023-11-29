using Domain.Dictionary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations.Dictionary;

public class CitizenshipConfiguration : IEntityTypeConfiguration<Citizenship>
{
    public void Configure(EntityTypeBuilder<Citizenship> builder)
    {
        builder.Property(c => c.NameRu).IsRequired().HasMaxLength(256);
        builder.Property(c => c.NameKg).IsRequired().HasMaxLength(256);

        builder.HasData(
            new Citizenship { Id = 1, NameRu = "Австралия", NameKg = "Австралия" },
            new Citizenship { Id = 2, NameRu = "Австрия", NameKg = "Австрия" },
            new Citizenship { Id = 3, NameRu = "Азербайджан", NameKg = "Азербайджан" },
            new Citizenship { Id = 4, NameRu = "Албания", NameKg = "Албания" },
            new Citizenship { Id = 5, NameRu = "Алжир", NameKg = "Алжир" },
            new Citizenship { Id = 6, NameRu = "Ангола", NameKg = "Ангола" },
            new Citizenship { Id = 7, NameRu = "Андорра", NameKg = "Андорра" },
            new Citizenship { Id = 8, NameRu = "Антигуа и Барбуда", NameKg = "Антигуа жана Барбуда" },
            new Citizenship { Id = 9, NameRu = "Аргентина", NameKg = "Аргентина" },
            new Citizenship { Id = 10, NameRu = "Армения", NameKg = "Армения" },
            new Citizenship { Id = 11, NameRu = "Афганистан", NameKg = "Ооганстан" },
            new Citizenship { Id = 12, NameRu = "Багамы", NameKg = "Багам Аралдары" },
            new Citizenship { Id = 13, NameRu = "Бангладеш", NameKg = "Бангладеш" },
            new Citizenship { Id = 14, NameRu = "Барбадос", NameKg = "Барбадос" },
            new Citizenship { Id = 15, NameRu = "Бахрейн", NameKg = "Бахрейн" },
            new Citizenship { Id = 16, NameRu = "Беларусь", NameKg = "Беларусь" },
            new Citizenship { Id = 17, NameRu = "Белиз", NameKg = "Белиз" },
            new Citizenship { Id = 18, NameRu = "Бельгия", NameKg = "Бельгия" },
            new Citizenship { Id = 19, NameRu = "Бенин", NameKg = "Бенин" },
            new Citizenship { Id = 20, NameRu = "Болгария", NameKg = "Болгария" },
            new Citizenship { Id = 21, NameRu = "Боливия", NameKg = "Боливия" },
            new Citizenship { Id = 22, NameRu = "Босния и Герцеговина", NameKg = "Босния жана Герцеговина" },
            new Citizenship { Id = 23, NameRu = "Ботсвана", NameKg = "Ботсвана" },
            new Citizenship { Id = 24, NameRu = "Бразилия", NameKg = "Бразилия" },
            new Citizenship { Id = 25, NameRu = "Бруней", NameKg = "Бруней" },
            new Citizenship { Id = 26, NameRu = "Буркина-Фасо", NameKg = "Буркина-Фасо" },
            new Citizenship { Id = 27, NameRu = "Бурунди", NameKg = "Бурунди" },
            new Citizenship { Id = 28, NameRu = "Бутан", NameKg = "Бутан" },
            new Citizenship { Id = 29, NameRu = "Вануату", NameKg = "Вануату" },
            new Citizenship { Id = 30, NameRu = "Великобритания", NameKg = "Улуу Британия" },
            new Citizenship { Id = 31, NameRu = "Венгрия", NameKg = "Венгрия" },
            new Citizenship { Id = 32, NameRu = "Венесуэла", NameKg = "Венесуэла" },
            new Citizenship { Id = 33, NameRu = "Восточный Тимор", NameKg = "Чыгыш Тимор" },
            new Citizenship { Id = 34, NameRu = "Вьетнам", NameKg = "Вьетнам" },
            new Citizenship { Id = 35, NameRu = "Габон", NameKg = "Габон" },
            new Citizenship { Id = 36, NameRu = "Гаити", NameKg = "Гаити" },
            new Citizenship { Id = 37, NameRu = "Гайана", NameKg = "Гайана" },
            new Citizenship { Id = 38, NameRu = "Гамбия", NameKg = "Гамбия" },
            new Citizenship { Id = 39, NameRu = "Гана", NameKg = "Гана" },
            new Citizenship { Id = 40, NameRu = "Гватемала", NameKg = "Гватемала" },
            new Citizenship { Id = 41, NameRu = "Гвинея", NameKg = "Гвинея" },
            new Citizenship { Id = 42, NameRu = "Гвинея-Бисау", NameKg = "Гвинея-Бисау" },
            new Citizenship { Id = 43, NameRu = "Германия", NameKg = "Германия" },
            new Citizenship { Id = 44, NameRu = "Гондурас", NameKg = "Гондурас" },
            new Citizenship { Id = 45, NameRu = "Гренада", NameKg = "Гренада" },
            new Citizenship { Id = 46, NameRu = "Греция", NameKg = "Греция" },
            new Citizenship { Id = 47, NameRu = "Грузия", NameKg = "Грузия" },
            new Citizenship { Id = 48, NameRu = "Дания", NameKg = "Дания" },
            new Citizenship { Id = 49, NameRu = "Джибути", NameKg = "Джибути" },
            new Citizenship { Id = 50, NameRu = "Доминика", NameKg = "Доминика" },
            new Citizenship { Id = 51, NameRu = "Доминикана", NameKg = "Доминикана" },
            new Citizenship { Id = 52, NameRu = "Египет", NameKg = "Египет" },
            new Citizenship { Id = 53, NameRu = "Замбия", NameKg = "Замбия" },
            new Citizenship { Id = 54, NameRu = "Зимбабве", NameKg = "Зимбабве" },
            new Citizenship { Id = 55, NameRu = "Израиль", NameKg = "Израиль" },
            new Citizenship { Id = 56, NameRu = "Индия", NameKg = "Индия" },
            new Citizenship { Id = 57, NameRu = "Индонезия", NameKg = "Индонезия" },
            new Citizenship { Id = 58, NameRu = "Иордания", NameKg = "Иордания" },
            new Citizenship { Id = 59, NameRu = "Ирак", NameKg = "Ирак" },
            new Citizenship { Id = 60, NameRu = "Иран", NameKg = "Иран" },
            new Citizenship { Id = 61, NameRu = "Ирландия", NameKg = "Ирландия" },
            new Citizenship { Id = 62, NameRu = "Исландия", NameKg = "Исландия" },
            new Citizenship { Id = 63, NameRu = "Испания", NameKg = "Испания" },
            new Citizenship { Id = 64, NameRu = "Италия", NameKg = "Италия" },
            new Citizenship { Id = 65, NameRu = "Йемен", NameKg = "Йемен" },
            new Citizenship { Id = 66, NameRu = "Кабо-Верде", NameKg = "Кабо-Верде" },
            new Citizenship { Id = 67, NameRu = "Казахстан", NameKg = "Казакстан" },
            new Citizenship { Id = 68, NameRu = "Камбоджа", NameKg = "Камбоджа" },
            new Citizenship { Id = 69, NameRu = "Камерун", NameKg = "Камерун" },
            new Citizenship { Id = 70, NameRu = "Канада", NameKg = "Канада" },
            new Citizenship { Id = 71, NameRu = "Катар", NameKg = "Катар" },
            new Citizenship { Id = 72, NameRu = "Кения", NameKg = "Кения" },
            new Citizenship { Id = 73, NameRu = "Кипр", NameKg = "Кипр" },
            new Citizenship { Id = 74, NameRu = "Кирибати", NameKg = "Кирибати" },
            new Citizenship { Id = 75, NameRu = "Китай", NameKg = "Кытай" },
            new Citizenship { Id = 76, NameRu = "Колумбия", NameKg = "Колумбия" },
            new Citizenship { Id = 77, NameRu = "Коморы", NameKg = "Комор Аралдары" },
            new Citizenship { Id = 78, NameRu = "Конго", NameKg = "Конго" },
            new Citizenship { Id = 79, NameRu = "ДР Конго", NameKg = "Конго Демократиялык Республикасы" },
            new Citizenship { Id = 80, NameRu = "КНДР", NameKg = "Корея Элдик Демократиялык Республикасы" },
            new Citizenship { Id = 81, NameRu = "Корея", NameKg = "Корея" },
            new Citizenship { Id = 82, NameRu = "Коста-Рика", NameKg = "Коста-Рика" },
            new Citizenship { Id = 83, NameRu = "Кот-д’Ивуар", NameKg = "Кот-д’Ивуар" },
            new Citizenship { Id = 84, NameRu = "Куба", NameKg = "Куба" },
            new Citizenship { Id = 85, NameRu = "Кувейт", NameKg = "Кувейт" },
            new Citizenship { Id = 86, NameRu = "Кыргызстан", NameKg = "Кыргызстан" },
            new Citizenship { Id = 87, NameRu = "Лаос", NameKg = "Лаос" },
            new Citizenship { Id = 88, NameRu = "Латвия", NameKg = "Латвия" },
            new Citizenship { Id = 89, NameRu = "Лесото", NameKg = "Лесото" },
            new Citizenship { Id = 90, NameRu = "Либерия", NameKg = "Либерия" },
            new Citizenship { Id = 91, NameRu = "Ливан", NameKg = "Ливан" },
            new Citizenship { Id = 92, NameRu = "Ливия", NameKg = "Ливия" },
            new Citizenship { Id = 93, NameRu = "Литва", NameKg = "Литва" },
            new Citizenship { Id = 94, NameRu = "Лихтенштейн", NameKg = "Лихтенштейн" },
            new Citizenship { Id = 95, NameRu = "Люксембург", NameKg = "Люксембург" },
            new Citizenship { Id = 96, NameRu = "Маврикий", NameKg = "Маврикий" },
            new Citizenship { Id = 97, NameRu = "Мавритания", NameKg = "Мавритания" },
            new Citizenship { Id = 98, NameRu = "Мадагаскар", NameKg = "Мадагаскар" },
            new Citizenship { Id = 99, NameRu = "Малави", NameKg = "Малави" },
            new Citizenship { Id = 100, NameRu = "Малайзия", NameKg = "Малайзия" },
            new Citizenship { Id = 101, NameRu = "Мали", NameKg = "Мали" },
            new Citizenship { Id = 102, NameRu = "Мальдивы", NameKg = "Мальдив Аралдары" },
            new Citizenship { Id = 103, NameRu = "Мальта", NameKg = "Мальта" },
            new Citizenship { Id = 104, NameRu = "Марокко", NameKg = "Марокко" },
            new Citizenship { Id = 105, NameRu = "Маршалловы Острова", NameKg = "Маршалл Аралдары" },
            new Citizenship { Id = 106, NameRu = "Мексика", NameKg = "Мексика" },
            new Citizenship { Id = 107, NameRu = "Микронезия", NameKg = "Микронезия" },
            new Citizenship { Id = 108, NameRu = "Мозамбик", NameKg = "Мозамбик" },
            new Citizenship { Id = 109, NameRu = "Молдавия", NameKg = "Молдавия" },
            new Citizenship { Id = 110, NameRu = "Монако", NameKg = "Монако" },
            new Citizenship { Id = 111, NameRu = "Монголия", NameKg = "Монголия" },
            new Citizenship { Id = 112, NameRu = "Мьянма", NameKg = "Мьянма" },
            new Citizenship { Id = 113, NameRu = "Намибия", NameKg = "Намибия" },
            new Citizenship { Id = 114, NameRu = "Науру", NameKg = "Науру" },
            new Citizenship { Id = 115, NameRu = "Непал", NameKg = "Непал" },
            new Citizenship { Id = 116, NameRu = "Нигер", NameKg = "Нигер" },
            new Citizenship { Id = 117, NameRu = "Нигерия", NameKg = "Нигерия" },
            new Citizenship { Id = 118, NameRu = "Нидерланды", NameKg = "Нидерланд" },
            new Citizenship { Id = 119, NameRu = "Никарагуа", NameKg = "Никарагуа" },
            new Citizenship { Id = 120, NameRu = "Новая Зеландия", NameKg = "Жаңы Зеландия" },
            new Citizenship { Id = 121, NameRu = "Норвегия", NameKg = "Норвегия" },
            new Citizenship { Id = 122, NameRu = "ОАЭ", NameKg = "Бириккен Араб Эмираттары" },
            new Citizenship { Id = 123, NameRu = "Оман", NameKg = "Оман" },
            new Citizenship { Id = 124, NameRu = "Пакистан", NameKg = "Пакистан" },
            new Citizenship { Id = 125, NameRu = "Палау", NameKg = "Палау" },
            new Citizenship { Id = 126, NameRu = "Панама", NameKg = "Панама" },
            new Citizenship { Id = 127, NameRu = "Папуа — Новая Гвинея", NameKg = "Папуа Жаңы Гвинея" },
            new Citizenship { Id = 128, NameRu = "Парагвай", NameKg = "Парагвай" },
            new Citizenship { Id = 129, NameRu = "Перу", NameKg = "Перу" },
            new Citizenship { Id = 130, NameRu = "Польша", NameKg = "Польша" },
            new Citizenship { Id = 131, NameRu = "Португалия", NameKg = "Португалия" },
            new Citizenship { Id = 132, NameRu = "Россия", NameKg = "Орусия" },
            new Citizenship { Id = 133, NameRu = "Руанда", NameKg = "Руанда" },
            new Citizenship { Id = 134, NameRu = "Румыния", NameKg = "Румыния" },
            new Citizenship { Id = 135, NameRu = "Сальвадор", NameKg = "Сальвадор" },
            new Citizenship { Id = 136, NameRu = "Самоа", NameKg = "Самоа" },
            new Citizenship { Id = 137, NameRu = "Сан-Марино", NameKg = "Сан-Марино" },
            new Citizenship { Id = 138, NameRu = "Сан-Томе и Принсипи", NameKg = "Сан Томе жана Принсипи" },
            new Citizenship { Id = 139, NameRu = "Саудовская Аравия", NameKg = "Сауд Арабия" },
            new Citizenship { Id = 140, NameRu = "Северная Македония", NameKg = "Түндүк Македония" },
            new Citizenship { Id = 141, NameRu = "Сейшелы", NameKg = "Сейшель Аралдар" },
            new Citizenship { Id = 142, NameRu = "Сенегал", NameKg = "Сенегал" },
            new Citizenship { Id = 143, NameRu = "Сент-Винсент и Гренадины", NameKg = "Сент-Винсент жана Гренадиндер" },
            new Citizenship { Id = 144, NameRu = "Сент-Китс и Невис", NameKg = "Сент-Китс жана Невис" },
            new Citizenship { Id = 145, NameRu = "Сент-Люсия	", NameKg = "Сент-Люсия" },
            new Citizenship { Id = 146, NameRu = "Сербия", NameKg = "Сербия" },
            new Citizenship { Id = 147, NameRu = "Сингапур", NameKg = "Сингапур" },
            new Citizenship { Id = 148, NameRu = "Сирия", NameKg = "Сирия" },
            new Citizenship { Id = 149, NameRu = "Словакия", NameKg = "Словакия" },
            new Citizenship { Id = 150, NameRu = "Словения", NameKg = "Словения" },
            new Citizenship { Id = 151, NameRu = "США", NameKg = "Америка Кошмо Штаттары" },
            new Citizenship { Id = 152, NameRu = "Соломоновы Острова", NameKg = "Соломон Аралдары" },
            new Citizenship { Id = 153, NameRu = "Сомали", NameKg = "Сомали" },
            new Citizenship { Id = 154, NameRu = "Судан", NameKg = "Судан" },
            new Citizenship { Id = 155, NameRu = "Суринам", NameKg = "Суринам" },
            new Citizenship { Id = 156, NameRu = "Сьерра-Леоне	", NameKg = "Сьерра-Леоне" },
            new Citizenship { Id = 157, NameRu = "Таджикистан", NameKg = "Тажикстан" },
            new Citizenship { Id = 158, NameRu = "Таиланд", NameKg = "Таиланд" },
            new Citizenship { Id = 159, NameRu = "Танзания", NameKg = "Танзания" },
            new Citizenship { Id = 160, NameRu = "Того", NameKg = "Того" },
            new Citizenship { Id = 161, NameRu = "Тонга", NameKg = "Тонга" },
            new Citizenship { Id = 162, NameRu = "Тринидад и Тобаго	", NameKg = "Тринидад жана Тобаго" },
            new Citizenship { Id = 163, NameRu = "Тувалу", NameKg = "Тувалу" },
            new Citizenship { Id = 164, NameRu = "Тунис", NameKg = "Тунис" },
            new Citizenship { Id = 165, NameRu = "Туркмения", NameKg = "Түркмөнстан" },
            new Citizenship { Id = 166, NameRu = "Турция", NameKg = "Түркия" },
            new Citizenship { Id = 167, NameRu = "Уганда", NameKg = "Уганда" },
            new Citizenship { Id = 168, NameRu = "Узбекистан", NameKg = "Өзбекстан" },
            new Citizenship { Id = 169, NameRu = "Украина", NameKg = "Украина" },
            new Citizenship { Id = 170, NameRu = "Уругвай", NameKg = "Уругвай" },
            new Citizenship { Id = 171, NameRu = "Фиджи", NameKg = "Фиджи" },
            new Citizenship { Id = 172, NameRu = "Филиппины", NameKg = "Филиппин" },
            new Citizenship { Id = 173, NameRu = "Финляндия", NameKg = "Финляндия" },
            new Citizenship { Id = 174, NameRu = "Франция", NameKg = "Франция" },
            new Citizenship { Id = 175, NameRu = "Хорватия", NameKg = "Хорватия" },
            new Citizenship { Id = 176, NameRu = "ЦАР", NameKg = "Борбордук Африка Республикасы" },
            new Citizenship { Id = 177, NameRu = "Чад", NameKg = "Чад" },
            new Citizenship { Id = 178, NameRu = "Черногория", NameKg = "Черногория" },
            new Citizenship { Id = 179, NameRu = "Чехия", NameKg = "Чехия" },
            new Citizenship { Id = 180, NameRu = "Чили", NameKg = "Чили" },
            new Citizenship { Id = 181, NameRu = "Швейцария", NameKg = "Швейцария" },
            new Citizenship { Id = 182, NameRu = "Швеция", NameKg = "Швеция" },
            new Citizenship { Id = 183, NameRu = "Шри-Ланка	", NameKg = "Шри-Ланка" },
            new Citizenship { Id = 184, NameRu = "Эквадор", NameKg = "Эквадор" },
            new Citizenship { Id = 185, NameRu = "Экваториальная Гвинея", NameKg = "Экваториалдык Гвинея" },
            new Citizenship { Id = 186, NameRu = "Эритрея", NameKg = "Эритрея" },
            new Citizenship { Id = 187, NameRu = "Эсватини", NameKg = "Эсватини" },
            new Citizenship { Id = 188, NameRu = "Эстония", NameKg = "Эстония" },
            new Citizenship { Id = 189, NameRu = "Эфиопия", NameKg = "Эфиопия" },
            new Citizenship { Id = 190, NameRu = "ЮАР", NameKg = "Түштүк Африка Республикасы" },
            new Citizenship { Id = 191, NameRu = "Южный Судан", NameKg = "Түштүк Судан" },
            new Citizenship { Id = 192, NameRu = "Ямайка", NameKg = "Ямайка" },
            new Citizenship { Id = 193, NameRu = "Япония", NameKg = "Жапония" }
        );
    }
}