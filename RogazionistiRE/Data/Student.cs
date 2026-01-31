using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.JsonBlueprints.SubBlueprints;
using RogazionistiRE.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RogazionistiRE.Data;

public class Student {
    private string                      ? _token              { get; set; }
    public  StudentJson                 ? _student            { get; set; }
    private StudentInfoJson             ? _info               ;
    private List<SubjectJson>           ? _subject            ;
    private List<GradeJson>             ? _grades             ;
    private List<CommitmentJson>        ? _commitment         ;
    private List<HomeworkJson>          ? _homework           ;
    private List<LessonArgumentJson>    ? _lesson             ;
    private List<AnnotationJson>        ? _annotation         ;
    private List<ReportCardJson>        ? _reportCards        ;
    private List<ComunicationThreadJson>? _comunicationThread ;
    private List<ComunicationUserJson>  ? _comunicationUser   ;
    private bool _demo;

    private Student(string token, StudentJson student, bool demo) {
        _token   = token;
        _student = student;
        _demo    = demo;
    }

    public async Task<StudentInfoJson> Info() {
        if (_info == null) _info = await getObject<StudentInfoJson>(APIs.getLoginInfoStudentAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_INFO_JSON);
        return _info;
    }
    public async Task<List<SubjectJson>> Subjects() {
        if (_subject == null) _subject = await getObject<List<SubjectJson>>(APIs.getSubjectsAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_SUBJECTS_JSON);
        return _subject;
    }
    public async Task<List<GradeJson>> Grades() {
        if (_grades == null) _grades = await getObject<List<GradeJson>>(APIs.getLoginInfoStudentAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_GRADES_JSON);
        return _grades;
    }
    public async Task<List<CommitmentJson>> Commitments() {
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
    public async Task<List<AnnotationJson>> Annotations() {
        if (_annotation == null) _annotation = await getObject<List<AnnotationJson>>(APIs.getAnnotationsAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_ANNOTATIONS_JSON);
        return _annotation;
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

    public SubjectJson? getSubject(int subjectID) {
        return _subject.FirstOrDefault(subject => subject.ID == subjectID);
    }

    public List<HomeworkJson>? getHomework(DateTime day) {
        return _homework.Where(homework => homework.Date >= day).ToList();
    }

    public string? getCurrentYearAndClass() {
        YearJson? currentYear = _student.Years.FirstOrDefault(year => year.ID == _student.CurrentYear);
        if (currentYear != null) {
            string currentYearString = currentYear.ID.Replace("_", "/");
            string currentClass = currentYear.Class;
            return $"{currentYearString}  -  {currentClass}";
        }
        return _student.CurrentYear.Replace("_", "/");
    }
    
    #region LOADING
    private async Task<T> getObject<T>(string endpoint = "", string jsonIfDemo = "") where T : class, new() {
        if (_demo) return deserialize<T>(jsonIfDemo);
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
    public static async Task<Student> createStudent(string token, StudentJson studentJson, bool demo) { 
        Student student = new Student(token, studentJson, demo); 
        return student;
    }
    
}

