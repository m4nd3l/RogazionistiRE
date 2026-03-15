using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.JsonBlueprints.SubBlueprints;
using RogazionistiRE.Util;
using RogazionistiRE.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RogazionistiRE.Data;

public class Student {
    private string                      ? _token              { get; set; }
    public  StudentJson                   _student            { get; set; }
    private StudentInfoJson             ? _info               ;
    private List<SubjectJson>           ? _subject            ;
    private List<GradeJson>             ? _grades             ;
    private List<CommitmentJson>        ? _commitment         ;
    private List<HomeworkJson>          ? _homework           ;
    private List<LessonArgumentJson>    ? _lesson             ;
    private List<AbsencesJson>          ? _absences           ;
    private List<AnnotationJson>        ? _annotations        ;
    private List<NotesJson>             ? _notes              ;
    private List<ReportCardJson>        ? _reportCards        ;
    private List<ComunicationThreadJson>? _comunicationThread ;
    private List<ComunicationUserJson>  ? _comunicationUser   ;

    private Student(string token, StudentJson student) {
        _token   = token;
        _student = student;
    }

    public string getName() {
        return _student.Name;
    }
    public string getFormattedName() {
        if (string.IsNullOrWhiteSpace(_student.Name))
            return _student.Name;

        var parts = _student.Name
            .Trim()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var textInfo = CultureInfo.CurrentCulture.TextInfo;

        for (int i = 0; i < parts.Length; i++) {
            parts[i] = textInfo.ToTitleCase(parts[i].ToLower());
        }

        return string.Join(" ", parts);
    }
    public YearJson? getCurrentYear() {
        return _student.Years.FirstOrDefault(year => year.ID == _student.CurrentYear);
    }
    public string? getClass() {
        YearJson? currentYear = getCurrentYear();
        if (currentYear != null) return currentYear.Class;
        return null;
    }
    public string? getCurrentYearAndClass() {
        YearJson? currentYear = getCurrentYear();
        if (currentYear != null) {
            string currentYearString = currentYear.ID.Replace("_", "/");
            string currentClass = currentYear.Class;
            return $"{currentYearString}  -  {currentClass}";
        }
        return _student.CurrentYear.Replace("_", "/");
    }
    
    #region Getters
    public async Task<StudentInfoJson> Info() {
        if (_info == null) _info = await getObject<StudentInfoJson>(APIs.getLoginInfoStudentAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_INFO_JSON);
        return _info;
    }
    public async Task<List<SubjectJson>> Subjects() {
        if (_subject == null) _subject = await getObject<List<SubjectJson>>(APIs.getSubjectsAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_SUBJECTS_JSON);
        return _subject;
    }
    public async Task<List<GradeJson>> Grades() {
        if (_grades == null) _grades = await getObject<List<GradeJson>>(APIs.getGradesAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_GRADES_JSON);
        return _grades;
    }
    public async Task<List<CommitmentJson>> Agenda() {
        if (_commitment == null) _commitment = await getObject<List<CommitmentJson>>(APIs.getAgendaAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_AGENDA_JSON);
        return _commitment;
    }
    public async Task<List<HomeworkJson>> Homework() {
        if (_homework == null) _homework = await getObject<List<HomeworkJson>>(APIs.getHomeworkAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_HOMEWORK_JSON);
        return _homework;
    }
    public async Task<List<LessonArgumentJson>> Lessons() {
        if (_lesson == null) _lesson = await getObject<List<LessonArgumentJson>>(APIs.getArgumentsAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_LESSONS_JSON);
        return _lesson;
    }
    public async Task<List<AbsencesJson>> Absences() {
        if (_absences == null) _absences = await getObject<List<AbsencesJson>>(APIs.getAbsencesAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_ABSENCES_JSON);
        return _absences;
    }
    public async Task<List<AnnotationJson>> Annotations() {
        if (_annotations == null) _annotations = await getObject<List<AnnotationJson>>(APIs.getAnnotationsAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_ANNOTATIONS_JSON);
        return _annotations;
    }
    
    public async Task<List<NotesJson>> Notes() {
        if (_notes == null) _notes = await getObject<List<NotesJson>>(APIs.getNotesAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_NOTES_JSON);
        return _notes;
    }
    public async Task<List<ReportCardJson>> ReportCards() {
        if (_reportCards == null) _reportCards = await getObject<List<ReportCardJson>>(APIs.getReportCardAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_REPORT_CARD_JSON);
        return _reportCards;
    }
    public async Task<List<ComunicationThreadJson>> ComunicationThread() {
        if (_comunicationThread == null) _comunicationThread = 
            await getObject<List<ComunicationThreadJson>>(APIs.getComunicationThreadsAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_COMUNICATION_THREAD_JSON);
        return _comunicationThread;
    }
    public async Task<List<ComunicationUserJson>> ComunicationUser() {
        if (_comunicationUser == null) _comunicationUser = 
            await getObject<List<ComunicationUserJson>>(APIs.getComunicationsUserAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_COMUNICATION_USER_JSON);
        return _comunicationUser;
    }

    public SubjectJson getSubject(int subjectID) {
        return _subject.FirstOrDefault(subject => subject.ID == subjectID);
    }

    public List<HomeworkJson> getHomework(DateTime day) {
        return _homework.Where(homework => homework.Date >= day).ToList();
    }
    #endregion
    
    #region LOADING
    private async Task<T> getObject<T>(string endpoint = "", string jsonIfDemo = "") where T : class, new() {
        if (ObjectManagement._demo) return deserialize<T>(jsonIfDemo);
        return await getRequest<T>(endpoint);
    }
    private async Task<T> getRequest<T>(string endpoint) where T : class, new() {
        string response = await APIs.getAsync(endpoint, _token);
        if (response.ToLower().Contains("server error")) {
            Debug.WriteLine($"Couldn't get information from API: {endpoint}.\nAPI Response: {response}");
            return null;
        }
        T instance = JsonSerializer.Deserialize<T>(response);
        if (instance == null) {
            Debug.WriteLine($"Couldn't serialize result into a {typeof(T)} object.\nJson received:\n{response}");
            return null;
        }
        return instance;
    }
    private T deserialize<T>(string json) where T : class, new() {
        T? result = JsonSerializer.Deserialize<T>(json);
        if (result == null) {
            Debug.WriteLine($"Couldn't serialize result into a {typeof(T)} object.\nJson:\n{json}");
            return null;
        }
        return result;
    }
    #endregion
    public static async Task<Student> createStudent(string token, StudentJson studentJson) { 
        Student student = new Student(token, studentJson); 
        return student;
    }
    
}

