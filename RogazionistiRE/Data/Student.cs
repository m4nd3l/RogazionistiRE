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
    public string                       _token              { get; set; }
    public StudentJson                  _student            { get; set; }
    public StudentInfoJson              _info               { get; set; }
    public List<SubjectJson>            _subject            { get; set; }
    public List<GradeJson>              _grades             { get; set; }
    public List<CommitmentJson>         _commitment         { get; set; }
    public List<HomeworkJson>           _homework           { get; set; }
    public List<LessonArgumentJson>     _lesson             { get; set; }
    public List<AnnotationJson>         _annotation         { get; set; }
    public List<ReportCardJson>         _reportCards        { get; set; }
    public List<ComunicationThreadJson> _comunicationThread { get; set; }
    public List<ComunicationUserJson>   _comunicationUser   { get; set; }
    private bool _demo;

    private Student(string token, StudentJson student, bool demo) {
        _token   = token;
        _student = student;
        _demo    = demo;
    }
    private async Task init() {
        if (_demo) {
            _info               = deserialize<StudentInfoJson>             (DemoJsons.CARLETTUCCINO_INFO_JSON);
            _subject            = deserialize<List<SubjectJson>>           (DemoJsons.CARLETTUCCINO_SUBJECTS_JSON);
            _grades             = deserialize<List<GradeJson>>             (DemoJsons.CARLETTUCCINO_GRADES_JSON);
            _commitment         = deserialize<List<CommitmentJson>>        (DemoJsons.CARLETTUCCINO_AGENDA_JSON);
            _homework           = deserialize<List<HomeworkJson>>          (DemoJsons.CARLETTUCCINO_HOMEWORK_JSON);
            _lesson             = deserialize<List<LessonArgumentJson>>    (DemoJsons.CARLETTUCCINO_LESSONS_JSON);
            _annotation         = deserialize<List<AnnotationJson>>        (DemoJsons.CARLETTUCCINO_ANNOTATIONS_JSON);
            _reportCards        = deserialize<List<ReportCardJson>>        (DemoJsons.CARLETTUCCINO_REPORT_CARD_JSON);
            _comunicationThread = deserialize<List<ComunicationThreadJson>>(DemoJsons.CARLETTUCCINO_COMUNICATION_THREAD_JSON);
            _comunicationUser   = deserialize<List<ComunicationUserJson>>  (DemoJsons.CARLETTUCCINO_COMUNICATION_USER_JSON);
            return;
        } 
        await loadOthers();
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
            string currentYearString = currentYear.ID.Replace("_", "-");
            string currentClass = currentYear.Class;
            return $"{currentYearString}  -  {currentClass}";
        }
        return _student.CurrentYear.Replace("_", "-");
    }
    
    #region LOADING
    private async Task loadOthers() {
        _info               = await getRequest<StudentInfoJson>             (APIs.getLoginInfoStudentAPIEndpoint   (_student));
        _subject            = await getRequest<List<SubjectJson>>           (APIs.getSubjectsAPIEndpoint           (_student));
        _grades             = await getRequest<List<GradeJson>>             (APIs.getGradesAPIEndpoint             (_student));
        _commitment         = await getRequest<List<CommitmentJson>>        (APIs.getAgendaAPIEndpoint             (_student));
        _homework           = await getRequest<List<HomeworkJson>>          (APIs.getHomeworkAPIEndpoint           (_student));
        _lesson             = await getRequest<List<LessonArgumentJson>>    (APIs.getArgumentsAPIEndpoint          (_student));
        _annotation         = await getRequest<List<AnnotationJson>>        (APIs.getAnnotationsAPIEndpoint        (_student));
        _reportCards        = await getRequest<List<ReportCardJson>>        (APIs.getReportCardAPIEndpoint         (_student));
        _comunicationThread = await getRequest<List<ComunicationThreadJson>>(APIs.getComunicationThreadsAPIEndpoint(_student));
        _comunicationUser   = await getRequest<List<ComunicationUserJson>>  (APIs.getComunicationsUserAPIEndpoint  (_student));
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
        await student.init(); 
        return student;
    }
    
}

