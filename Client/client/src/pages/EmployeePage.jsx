import { useEffect, useState } from 'react'
import { Button, Modal } from 'react-bootstrap'

export function EmployeePage() {
  const [rowData, setRowData] = useState([])
  const [selectedRow, setSelectedRow] = useState({
    id_employee: 1,
    username: 'ndoutch0',
    first_name: 'Nora',
    last_name: 'Doutch',
    email: 'ndoutch0@ifeng.com',
    phone: '+66 (933) 518-8881',
    gender: 'Female',
    address: '07 Jenna Point',
    department: 'Support',
    password: '39liQ0nr',
    about: 'quisque porta volutpat erat quisque erat eros viverra eget congue eget',
  })

  const [showFormDialog, setShowFormDialog] = useState(false)
  const [showDeleteDialog, setShowDeleteDialog] = useState(false)

  useEffect(() => {
    fetch('http://localhost:5221/api/v1/employee')
      .then((res) => res.json())
      .then((data) => setRowData(data.filter((e, i) => i < 10)))
  }, [])

  function editAction(row) {
    setSelectedRow(row)
    setShowFormDialog(true)
  }
  function deleteAction(row) {
    setShowDeleteDialog(true)
  }

  return (
    <div>
      <h1 className='display-4'>Gestão de Funcionário</h1>
      {/* <p>Gerir funcionários</p> */}
      <div className='d-flex justify-content-end w-100'>
        <button className='btn btn-success'>Adicionar</button>
      </div>
      <table className='table table-striped'>
        <thead>
          <tr>
            <th>#</th>
            <th>Name</th>
            <td>Email</td>
            <th width='150px' className='text-center'>
              Ações
            </th>
          </tr>
        </thead>
        <tbody>
          {
            //
            rowData.map((row, rowIndex) => (
              <tr key={`row-${rowIndex}`}>
                <td>{row.id_employee}</td>
                <td>{row.first_name + ' ' + row.last_name}</td>
                <td>{row.email}</td>
                <td className='d-flex gap-2 p-1'>
                  <button className='btn btn-primary' onClick={() => editAction(row)}>
                    Edit
                  </button>
                  <button className='btn btn-danger' onClick={() => deleteAction(row)}>
                    Delete
                  </button>
                </td>
              </tr>
            ))
          }
        </tbody>
      </table>
      <DialogEditFormEmployee data={selectedRow} show={showFormDialog} setShow={setShowFormDialog} />
      <DialogDeleteEmployee show={showDeleteDialog} setShow={setShowDeleteDialog} />
    </div>
  )
}

function DialogEditFormEmployee({ data, show, setShow }) {
  const [employee, setEmployee] = useState({
    id_employee: 1,
    username: 'ndoutch0',
    first_name: 'Nora',
    last_name: 'Doutch',
    email: 'ndoutch0@ifeng.com',
    phone: '+66 (933) 518-8881',
    gender: 'Female',
    address: '07 Jenna Point',
    department: 'Support',
    password: '39liQ0nr',
    about: 'quisque porta volutpat erat quisque erat eros viverra eget congue eget',
  })

  const close = () => setShow(false)

  const onChangeInput = (e) => {
    const { id, value } = e.target

    setEmployee({ ...employee, [id]: value })
  }

  const submit = () => {
    console.log(employee)
  }
  return (
    <Modal show={true} onHide={close}>
      <form>
        <Modal.Header closeButton>
          <Modal.Title>Editar Funcionário</Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <div className='row'>
            <div className='col-4 mb-3'>
              <label className='form-label' htmlFor='username'>
                Usuário
              </label>
              <input
                value={employee.username}
                onChange={onChangeInput}
                className='form-control'
                id='username'
                type='text'
                placeholder='Usuário'
              />
              <div className='invalid-feedback'>Usuário is required.</div>
            </div>
            <div className='col-4 mb-3'>
              <label className='form-label' htmlFor='first_name'>
                Primeiro Nome
              </label>
              <input
                value={employee.first_name}
                onChange={onChangeInput}
                className='form-control'
                id='first_name'
                type='text'
                placeholder='Primeiro Nome'
              />
              <div className='invalid-feedback'>Primeiro Nome is required.</div>
            </div>
            <div className='col-4 mb-3'>
              <label className='form-label' htmlFor='last_name'>
                Último Nome
              </label>
              <input
                value={employee.last_name}
                onChange={onChangeInput}
                className='form-control'
                id='last_name'
                type='text'
                placeholder='Último Nome'
              />
              <div className='invalid-feedback'>Último Nome is required.</div>
            </div>
            <div className='col-6 mb-3'>
              <label className='form-label' htmlFor='emailAddress'>
                Email Address
              </label>
              <input
                value={employee.emailAddress}
                onChange={onChangeInput}
                className='form-control'
                id='emailAddress'
                type='email'
                placeholder='Email Address'
                data-sb-validations='required,email'
              />
              <div className='invalid-feedback'>Email Address is required.</div>
              <div className='invalid-feedback' data-sb-feedback='emailAddress:email'>
                Email Address Email is not valid.
              </div>
            </div>
            <div className='col-6 mb-3'>
              <label className='form-label' htmlFor='phone'>
                Telefone
              </label>
              <input
                value={employee.phone}
                onChange={onChangeInput}
                className='form-control'
                id='phone'
                type='text'
                placeholder='Telefone'
              />
              <div className='invalid-feedback'>Telefone is required.</div>
            </div>
            <div className='col-12 mb-3'>
              <label className='form-label d-block'>Gênero</label>
              <div className='form-check form-check-inline'>
                <input className='form-check-input' id='masculino' type='radio' name='genero' />
                <label className='form-check-label' htmlFor='masculino'>
                  Masculino
                </label>
              </div>
              <div className='form-check form-check-inline'>
                <input className='form-check-input' id='feminino' type='radio' name='genero' />
                <label className='form-check-label' htmlFor='feminino'>
                  Feminino
                </label>
              </div>
              <div className='form-check form-check-inline'>
                <input className='form-check-input' id='naoBinario' type='radio' name='genero' />
                <label className='form-check-label' htmlFor='naoBinario'>
                  Não Binário
                </label>
              </div>
              <div className='invalid-feedback'>One option is required.</div>
            </div>
            <div className='col-6 mb-3'>
              <label className='form-label' htmlFor='address'>
                Endereço
              </label>
              <input
                value={employee.address}
                onChange={onChangeInput}
                className='form-control'
                id='address'
                type='text'
                placeholder='Endereço'
              />
              <div className='invalid-feedback'>Endereço is required.</div>
            </div>
            <div className='col-6 mb-3'>
              <label className='form-label' htmlFor='department'>
                Departamento
              </label>
              <input
                value={employee.department}
                onChange={onChangeInput}
                className='form-control'
                id='department'
                type='text'
                placeholder='Departamento'
              />
              <div className='invalid-feedback'>Departamento is required.</div>
            </div>
            <div className='col-12 mb-3'>
              <label className='form-label' htmlFor='about'>
                Sobre
              </label>
              <textarea
                value={employee.about}
                onChange={onChangeInput}
                className='form-control'
                id='about'
                type='text'
                placeholder='Sobre'
              ></textarea>
              <div className='invalid-feedback'>Sobre is required.</div>
            </div>
            <div className='d-none' id='submitSuccessMessage'>
              <div className='text-center mb-3'>
                <div className='fw-bolder'>Form submission successful!</div>
              </div>
            </div>
            <div className='d-none' id='submitErrorMessage'>
              <div className='text-center text-danger mb-3'>Error sending message!</div>
            </div>
          </div>
        </Modal.Body>
        <Modal.Footer>
          <Button variant='danger' onClick={close}>
            Cancelar
          </Button>
          <Button variant='primary' onClick={submit}>
            Salvar
          </Button>
        </Modal.Footer>
      </form>
    </Modal>
  )
}

function DialogDeleteEmployee({ show, setShow }) {
  const close = () => setShow(false)
  return (
    <>
      <Modal show={show} onHide={close}>
        <Modal.Header closeButton>
          <Modal.Title>Modal heading</Modal.Title>
        </Modal.Header>
        <Modal.Body>Woohoo, you're reading this text in a modal!</Modal.Body>
        <Modal.Footer>
          <Button variant='secondary' onClick={close}>
            Close
          </Button>
          <Button variant='primary' onClick={close}>
            Save Changes
          </Button>
        </Modal.Footer>
      </Modal>
    </>
  )
}
