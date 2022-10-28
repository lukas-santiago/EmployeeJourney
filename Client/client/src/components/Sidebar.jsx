import { Link, NavLink } from 'react-router-dom';

export function Sidebar() {
  return (
    <div id='sidebar' className='d-flex flex-column flex-shrink-0 pt-5 p-4 bg-light'>
      <Link to='/' className='d-flex align-items-center mb-3 mb-md-0 me-md-auto link-dark text-decoration-none'>
        <svg className='bi me-2' width='40' height='32'></svg>
        <h3 className='fs-4'>Jornada do Funcionário</h3>
      </Link>
      <hr />
      <ul className='nav nav-pills flex-column mb-auto'>
        <li className='nav-item'>
          <NavLink to='/' className='nav-link link-dark' end>
            <svg className='bi me-2' width='16' height='16'></svg>
            Início
          </NavLink>
        </li>
        <li>
          <NavLink to='/employee' className='nav-link link-dark'>
            <svg className='bi me-2' width='16' height='16'></svg>
            Gestão de Funcionários
          </NavLink>
        </li>
      </ul>
    </div>
  );
}
