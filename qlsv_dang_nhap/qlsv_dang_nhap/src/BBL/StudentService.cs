﻿using System.Data;
using System.Windows.Documents;

class StudentService
{
    private readonly StudentRepository _studentRepository;
    public StudentService(StudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public DataTable getAllStudent()
    {
        return _studentRepository.GetStudents();
    }

    public void AddStudent(Student student)
    {
        try
        {
            _studentRepository.AddStudent(student);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void UpdateStudent(Student student)
    {

    }
    public void DeleteStudent(int id)
    {
        int abc;
    }

    public long getLastestAdmissionId()
    {
        return _studentRepository.getLastestAdmissionId();
    }

    public DataTable? SearchStudent(string keyword)
    {
        if (keyword == null)
        {
            throw new Exception("Vui lòng nhập từ khóa tìm kiếm");
        }
        try
        {
            return _studentRepository.SearchStudent(keyword);

        }
        catch (Exception e)
        {
            throw new Exception("Looix: " + e.Message);
        }
    }
}

