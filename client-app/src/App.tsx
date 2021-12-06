import React, { useEffect, useState } from 'react';
import './App.css';
import axios from 'axios';


function App() {

  // const hi = () => {
    // }
    
    const [activities, setActivities] = useState([]);
    
    useEffect(() => {
    console.log(activities)

    axios.get('http://localhost:5000/api/Activity').then(response => {
    console.log(response);
    setActivities(response.data);
    })
  }, [])


  return (
    <div className="App">
      <header className="App-header">
        <h2>hi</h2>
       <ul>
         {activities.map((activity: any) => (
           <li key={activity.id}>
             {activity.title}
           </li>
         ))}
       </ul>
      </header>
    </div>
  );
}

export default App;
