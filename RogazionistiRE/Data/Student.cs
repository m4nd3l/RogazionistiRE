using RogazionistiRE.JsonBlueprints;
using RogazionistiRE.JsonBlueprints.SubBlueprints;
using RogazionistiRE.Util;
using RogazionistiRE.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RogazionistiRE.Data;

public class Student {
    private string                                      ? _token   { get; set; }
    private string                                      ? _id      { get; set; }
    private string                                      ? _fName   { get; set; }
    private int                                           _index   { get; set; }
    public  StudentJson                                   _student { get; set; }
    private StudentInfoJson                             ? _info               ;
    private ObservableCollection<SubjectJson>           ? _subject            ;
    private ObservableCollection<GradeJson>             ? _grades             ;
    private ObservableCollection<AgendaJson>        ? _events         ;
    private ObservableCollection<ObservableHomework>    ? _homework           ;
    private ObservableCollection<LessonJson>    ? _lesson             ;
    private ObservableCollection<AbsencesJson>          ? _absences           ;
    private ObservableCollection<AnnotationJson>        ? _annotations        ;
    private ObservableCollection<NotesJson>             ? _notes              ;
    private ObservableCollection<ReportCardJson>        ? _reportCards        ;
    private ObservableCollection<ComunicationThreadJson>? _comunicationThread ;
    private ObservableCollection<ComunicationUserJson>  ? _comunicationUser   ;
    private Student(string token, string id, StudentJson student) {
        _token   = token;
        _id      = id;
        _student = student;
        _index   = ObjectManagement._resultJson.Students.FindLastIndex(student => $"{student.ID}".Equals(_id));
        
        if (string.IsNullOrWhiteSpace(_student.Name))
            _fName = _student.Name;

        var parts = _student.Name
            .Trim()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var textInfo = CultureInfo.CurrentCulture.TextInfo;

        for (int i = 0; i < parts.Length; i++) {
            parts[i] = textInfo.ToTitleCase(parts[i].ToLower());
        }

        _fName =  string.Join(" ", parts);
    }
    
    public static async Task<Student> createStudent(string token, string id, StudentJson studentJson) {
        Student student = new Student(token, id, studentJson);
        return student;
    }

    public async Task save() {
        await Homework();
        await ObservableHomework.save(_homework, _id);
    }
    
    public string getName() {
        return _student.Name;
    }
    
    public string getFormattedName() {
        return _fName;
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

    public void updateHomeworkStatus(int index, bool status) {
        if (index >= 0 && index < _homework.Count) _homework[index].Done = status;
    }
    
    public int getHomeworkIndex(ObservableHomework target) {
        if (_homework == null) return -1;
        return _homework.ToList().FindIndex(hw => hw.Equals(target));
    }
    
    #region GETTERS
    public async Task<StudentInfoJson> Info() {
        if (_info == null) _info = 
            await getSingleObject<StudentInfoJson>(APIs.getLoginInfoStudentAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_INFO_JSON);
        return _info;
    }
    public async Task<ObservableCollection<SubjectJson>> Subjects() {
        if (_subject != null) _subject = 
            new ObservableCollection<SubjectJson>(await getObject<SubjectJson>(APIs.getSubjectsAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_SUBJECTS_JSON));
        return _subject;
    }
    public async Task<ObservableCollection<GradeJson>> Grades(DateTime? date = null) {
        if (_grades == null) _grades = 
            new ObservableCollection<GradeJson>(await getObject<GradeJson>(APIs.getGradesAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_GRADES_JSON));
        if (date == null) return _grades;
        return new ObservableCollection<GradeJson>(_grades.Where(x => x.Date.Date == date.Value.Date).ToList());
    }
    public async Task<ObservableCollection<AgendaJson>> Agenda(DateTime? date = null) {
        if (_events == null) _events = 
            new ObservableCollection<AgendaJson>(await getObject<AgendaJson>(APIs.getAgendaAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_AGENDA_JSON));
        if (date == null) return _events;
        return new ObservableCollection<AgendaJson>(_events.Where(x => x.Date.Date == date.Value.Date).ToList());
    }
    public async Task<ObservableCollection<ObservableHomework>> Homework(DateTime? date = null) {
        if (_homework == null) {
            string oldJson = FileWriter.readJsonFromFileAsync(_id);
            var oldOnes = oldJson != "false" ? JsonSerializer.Deserialize<List<ObservableHomework>>(oldJson) : null;
            var newOnes = await getObject<HomeworkJson>(APIs.getHomeworkAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_HOMEWORK_JSON);
            _homework = ObservableHomework.merge(oldOnes, newOnes);
        }
        
        if (date == null) return _homework;

        var filtered = _homework.Where(x => x.Date.Date == date.Value.Date).ToList();
        return new ObservableCollection<ObservableHomework>(filtered);
    }
    public async Task<ObservableCollection<LessonJson>> Lessons(DateTime? date = null) {
        if (_lesson == null) _lesson = 
            new ObservableCollection<LessonJson>(await getObject<LessonJson>(APIs.getArgumentsAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_LESSONS_JSON));
        if (date == null) return _lesson;
        return new ObservableCollection<LessonJson>(_lesson.Where(x => x.Date.Date == date.Value.Date).ToList());
    }
    public async Task<ObservableCollection<AbsencesJson>> Absences(DateTime? date = null) {
        if (_absences == null) _absences = 
            new ObservableCollection<AbsencesJson>(await getObject<AbsencesJson>(APIs.getAbsencesAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_ABSENCES_JSON));
        if (date == null) return _absences;
        return new ObservableCollection<AbsencesJson>(_absences.Where(x => x.Date.Date == date.Value.Date).ToList());
    }
    public async Task<ObservableCollection<AnnotationJson>> Annotations(DateTime? date = null) {
        if (_annotations == null) _annotations = 
            new ObservableCollection<AnnotationJson>(await getObject<AnnotationJson>(APIs.getAnnotationsAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_ANNOTATIONS_JSON));
        if (date == null) return _annotations;
        return new ObservableCollection<AnnotationJson>(_annotations.Where(x => x.Date.Date == date.Value.Date).ToList());
    }
    public async Task<ObservableCollection<NotesJson>> Notes(DateTime? date = null) {
        if (_notes == null) _notes = 
            new ObservableCollection<NotesJson>(await getObject<NotesJson>(APIs.getNotesAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_NOTES_JSON));
        if (date == null) return _notes;
        return new ObservableCollection<NotesJson>(_notes.Where(x => x.Date.Date == date.Value.Date).ToList());
    }
    public async Task<ObservableCollection<ReportCardJson>> ReportCards() {
        if (_reportCards == null) _reportCards = 
            new ObservableCollection<ReportCardJson>(await getObject<ReportCardJson>(APIs.getReportCardAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_REPORT_CARD_JSON));
        return _reportCards;
    }
    public async Task<ObservableCollection<ComunicationThreadJson>> ComunicationThread() {
        if (_comunicationThread == null) _comunicationThread =
            new ObservableCollection<ComunicationThreadJson>(await getObject<ComunicationThreadJson>(APIs.getComunicationThreadsAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_COMUNICATION_THREAD_JSON));
        return _comunicationThread;
    }
    public async Task<ObservableCollection<ComunicationUserJson>> ComunicationUser() {
        if (_comunicationUser == null) _comunicationUser =
            new ObservableCollection<ComunicationUserJson>(await getObject<ComunicationUserJson>(APIs.getComunicationsUserAPIEndpoint(_student), DemoJsons.CARLETTUCCINO_COMUNICATION_USER_JSON));
        return _comunicationUser;
    }
    #endregion
    #region LOADER
    private async Task<List<T>> getObject<T>(string endpoint = "", string jsonIfDemo = "") where T : Blueprint, new() {
        if (ObjectManagement._demo) return deserialize<T>(jsonIfDemo);
        return await getRequest<T>(endpoint);
    }
    private async Task<List<T>> getRequest<T>(string endpoint) where T : Blueprint, new() {
        string response = await APIs.getAsync(endpoint, _token);
        if (response.ToLower().Contains("server error")) {
            Debug.WriteLine($"Couldn't get information from API: {endpoint}.\nAPI Response: {response}");
            return null;
        }
        return deserialize<T>(response);
    }
    private List<T> deserialize<T>(string json) where T : Blueprint, new() {
        List<T>? result = JsonSerializer.Deserialize<List<T>>(json);
        if (result == null) Debug.WriteLine($"Couldn't serialize result into a {typeof(T)} object.\nJson:\n{json}");
        foreach (var blueprint in result) blueprint.format();
        return result;
    }
    
    private async Task<T> getSingleObject<T>(string endpoint = "", string jsonIfDemo = "") where T : class, new() {
        if (ObjectManagement._demo) return deserializeSingleObject<T>(jsonIfDemo);
        return await getRequestSingleObject<T>(endpoint);
    }
    private async Task<T> getRequestSingleObject<T>(string endpoint) where T : class, new() {
        string response = await APIs.getAsync(endpoint, _token);
        if (response.ToLower().Contains("server error")) {
            Debug.WriteLine($"Couldn't get information from API: {endpoint}.\nAPI Response: {response}");
            return null;
        }
        return deserializeSingleObject<T>(response);
    }
    private T deserializeSingleObject<T>(string json) where T : class, new() {
        T? result = JsonSerializer.Deserialize<T>(json);
        if (result == null) Debug.WriteLine($"Couldn't serialize result into a {typeof(T)} object.\nJson:\n{json}");
        return result;
    }
    #endregion
}

