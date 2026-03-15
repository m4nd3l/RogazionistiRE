namespace RogazionistiRE.Language;
public class LanguageKeys {

    public static readonly LanguageKeys RogazionistiRE_Winbar = new LanguageKeys("app.winbar.prefix");
    
    public static readonly LanguageKeys Error_Errors = new LanguageKeys("error.error.text");
    
    public static readonly LanguageKeys LoggingIn_Notification = new LanguageKeys("loggingin.notifications.text");

    public static readonly LanguageKeys Welcome_LoginPage = new LanguageKeys("welcome.login_page.text");
    public static readonly LanguageKeys Signin_LoginPage = new LanguageKeys("signin.login_page.text");
    public static readonly LanguageKeys Authenticating_LoginPage = new LanguageKeys("authenticating.login_page.text");
    public static readonly LanguageKeys Username_LoginPage = new LanguageKeys("username.login_page.field_placeholder");
    public static readonly LanguageKeys Password_LoginPage = new LanguageKeys("password.login_page.field_placeholder");
    public static readonly LanguageKeys RememberMe_LoginPage = new LanguageKeys("remember_me.login_page.checkbox_text");
    public static readonly LanguageKeys Login_LoginPage = new LanguageKeys("login.login_page.button_text");
    public static readonly LanguageKeys ErrorFields_LoginPage = new LanguageKeys("error_fields_empty.login_page.text");
    public static readonly LanguageKeys ErrorCreds_LoginPage = new LanguageKeys("error_invalid_credentials.login_page.text");
    public static readonly LanguageKeys ErrorAutoCreds_LoginPage = new LanguageKeys("error_invalid_auto_credentials.login_page.text");
    public static readonly LanguageKeys ErrorAutoCredsNotFound_LoginPage = new LanguageKeys("error_auto_credentials_not_found.login_page.text");
    public static readonly LanguageKeys PickALanguage_LoginPage = new LanguageKeys("pick_a_language.login_page.text");
    public static readonly LanguageKeys ChangeLanguage_LoginPage = new LanguageKeys("change_language.login_page.text");
    public static readonly LanguageKeys Error_LoginPage = new LanguageKeys("error.login_page.text");

    public static readonly LanguageKeys Students_StudentsPage = new LanguageKeys("title.students_page.text");
    public static readonly LanguageKeys Settings_StudentsPage = new LanguageKeys("settings.students_page.button_text");
    public static readonly LanguageKeys Logout_StudentsPage = new LanguageKeys("logout.students_page.button_text");
    public static readonly LanguageKeys Welcome_StudentsPage = new LanguageKeys("welcome.students_page.text");

    public static readonly LanguageKeys Home_StudentPage = new LanguageKeys("home.student_page.button_text");
    public static readonly LanguageKeys Grades_StudentPage = new LanguageKeys("grades.student_page.button_text");
    public static readonly LanguageKeys Agenda_StudentPage = new LanguageKeys("agenda.student_page.button_text");
    public static readonly LanguageKeys Absences_StudentPage = new LanguageKeys("absences.student_page.button_text");
    public static readonly LanguageKeys Notes_StudentPage = new LanguageKeys("notes.student_page.button_text");
    public static readonly LanguageKeys Communications_StudentPage = new LanguageKeys("communications.student_page.button_text");
    public static readonly LanguageKeys ReportCards_StudentPage = new LanguageKeys("report_cards.student_page.button_text");
    public static readonly LanguageKeys Subjects_StudentPage = new LanguageKeys("subjects.student_page.button_text");
    public static readonly LanguageKeys MoreInfo_StudentPage = new LanguageKeys("more_info.student_page.button_text");

    public static readonly LanguageKeys Name_MoreInfoPage = new LanguageKeys("name.more_info_page.text");
    public static readonly LanguageKeys CurrentYear_MoreInfoPage = new LanguageKeys("current_year.more_info_page.text");
    public static readonly LanguageKeys Province_MoreInfoPage = new LanguageKeys("province.more_info_page.text");
    public static readonly LanguageKeys School_MoreInfoPage = new LanguageKeys("school.more_info_page.text");
    public static readonly LanguageKeys Class_MoreInfoPage = new LanguageKeys("class.more_info_page.text");
    public static readonly LanguageKeys AverageGrade_MoreInfoPage = new LanguageKeys("average_grade.more_info_page.text");
    public static readonly LanguageKeys Notes_MoreInfoPage = new LanguageKeys("notes.more_info_page.text");
    public static readonly LanguageKeys Close_MoreInfoPage = new LanguageKeys("close.more_info_page.button_text");
    
    private string key;
    public LanguageKeys(string key) { this.key = key; }
    public override string ToString() => key;

}

