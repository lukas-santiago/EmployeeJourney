import './App.css'
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom'

import { Sidebar } from './components/Sidebar'
import { HomePage } from './pages/HomePage'
import { EmployeePage } from './pages/EmployeePage'
import { EmployeeFormPage } from './pages/EmployeeFormPage'

function App() {
  return (
    <Router>
      <div className='App'>
        <Sidebar />
        <div className='flex-grow-1 overflow-auto'>
          <div className='container pt-5 p-5 overflow-auto'>
            <Routes>
              <Route exact path='/' element={<HomePage />}></Route>
              <Route path='/employee' element={<EmployeePage />}></Route>
              <Route path='/employee/:id' element={<EmployeeFormPage />}></Route>
            </Routes>
          </div>
        </div>
      </div>
    </Router>
  )
}

export default App
