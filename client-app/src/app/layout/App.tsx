import { Container, Grid } from 'semantic-ui-react'
import NavBar from './NavBar'
import WeekView from './WeekView'
import MealDetails from '../features/meals/MealDetails'

function App() {

  return (
  <>
    <NavBar/>
    <WeekView/>
    <MealDetails/>
  </>

  )
}

export default App
