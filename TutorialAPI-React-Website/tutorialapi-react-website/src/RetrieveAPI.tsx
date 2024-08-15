import React, {useState, useEffect, require} from 'react';



interface Student{
    id: number;
    name: string;
    firstName: string;
    lastName: string;
    lastGrade: number;
}

interface Post{
    id: number;
    title: string;
}

const BASE_URL = 'http://localhost:7132/api/Student';

function RetrieveAPI(){
    
    var express = require('express')
var cors = require('cors')
var app = express()

app.use(cors())

app.get('/products/:id', function (req, res, next) {
  res.json({msg: 'This is CORS-enabled for all origins!'})
})

app.listen(80, function () {
  console.log('CORS-enabled web server listening on port 80')
})
    
    const[students, setStudents] = useState<Student[]>([]);

    useEffect(() => {
        const fetchResult = async () => {
            const response = await fetch(`${BASE_URL}`);
            const students = (await response.json()) as Student[];
            setStudents(students);
            }

            fetchResult();
        }, []);

    const resultStudents = students.map((student) => {<li key={student.id}>{student.id}</li>})

    return (
        <>
        <ul>{students.map((student) => { return <li key={student.id}>{student.id}</li>})}</ul>
        <p>test</p>
        </>
    );
}

export default RetrieveAPI