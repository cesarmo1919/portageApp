import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import React, { useEffect, useState } from 'react';
import { Header, List } from 'semantic-ui-react';

function App() {
  const [missions, setMissions] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/missions')
      .then(response => {
        console.log(response);
        setMissions(response.data);
      })
  }, [])

  return (
    <div>
      <Header as='h2' icon='users' content='Missions' />

        <List>
          {missions.map((mission: any) => (
            <List.Item key={mission.id}>
              {mission.bUnit}
            </List.Item>
          ))}
        </List>

    </div>
  );
}

export default App;
