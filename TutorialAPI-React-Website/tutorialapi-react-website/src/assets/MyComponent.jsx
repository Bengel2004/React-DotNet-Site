import React, {useState} from 'react';


function MyComponent(){
    const [name, setName] = useState();
    const [age, setAge] = useState(0);
    const [isEmployed, setIsEmployed] = useState(false);

    const updateName = () => {setName("Spongebob");}
    const incrementAge = () => {setAge(age+1);}
    const updateEmployment = () => {setIsEmployed(!isEmployed);}
    

    return(
        <div>
            <p>Name: {name}</p>
            <p>Age: {age}</p>
            <p>Is employed: {isEmployed ? "Yes" : "No"}</p>
            <button onClick={updateName}>Set Name</button>
            <button onClick={incrementAge}>Set Age</button>
            <button onClick={updateEmployment}>Update Employment</button>
        </div>
    );
}


export default MyComponent