import './App.css'
import { BrowserRouter as Router, Routes, Route, Link, NavLink } from 'react-router-dom'
import { useEffect } from 'react'
import { useState } from 'react'

function App() {
  return (
    <Router>
      <div className="App">
        <Sidebar />
        <div className="flex-grow-1 overflow-auto">
          <div className="container pt-5 p-5 overflow-auto">
            <Routes>
              <Route exact path="/" element={<HomePage />}></Route>
              <Route path="/employee" element={<EmployeePage />}></Route>
            </Routes>
          </div>
        </div>
      </div>
    </Router>
  )
}

function Sidebar() {
  return (
    <div id="sidebar" className="d-flex flex-column flex-shrink-0 pt-5 p-4 bg-light">
      <Link to="/" className="d-flex align-items-center mb-3 mb-md-0 me-md-auto link-dark text-decoration-none">
        <svg className="bi me-2" width="40" height="32"></svg>
        <h3 className="fs-4">Jornada do Funcionário</h3>
      </Link>
      <hr />
      <ul className="nav nav-pills flex-column mb-auto">
        <li className="nav-item">
          <NavLink to="/" className="nav-link link-dark" end>
            <svg className="bi me-2" width="16" height="16"></svg>
            Início
          </NavLink>
        </li>
        <li>
          <NavLink to="/employee" className="nav-link link-dark">
            <svg className="bi me-2" width="16" height="16"></svg>
            Gestão de Funcionários
          </NavLink>
        </li>
      </ul>
    </div>
  )
}

function HomePage() {
  return (
    <div>
      <h1>dsadas</h1>
      <p>asjdasipjsa</p>
    </div>
  )
}
function EmployeePage() {
  const [rowData, setRowData] = useState([])

  useEffect(() => {
    fetch('http://localhost:5221/api/v1/employee')
      .then((res) => res.json())
      .then((data) => setRowData(data.filter((e, i) => i < 10)))
  }, [])

  function editAction(row) {}
  function deleteAction(row) {}

  return (
    <div>
      <h1 className="display-4">Gestão de Funcionário</h1>
      <p>asjdasipjsa</p>
      <table>
        <thead>
          <tr>
            <th>#</th>
            <th>Name</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {rowData.map((row, rowIndex) => (
            <tr key={`row-${rowIndex}`}>
              <td>{row.id_employee}</td>
              <td>{row.first_name + ' ' + row.last_name}</td>
              <td className="d-flex gap-2 p-1">
                <button className="btn btn-primary" onClick={editAction(row)}>
                  Edit
                </button>
                <button className="btn btn-danger" onClick={deleteAction(row)}>
                  Delete
                </button>
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  )
}

export default App
