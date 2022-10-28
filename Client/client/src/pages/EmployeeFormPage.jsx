import { useEffect, useState } from "react"
import { Button } from "react-bootstrap"
import { useParams } from "react-router-dom"

export function EmployeeFormPage() {
    const { id } = useParams()
    const [employee, setEmployee] = useState({
        id_employee: 0,
        username: '',
        first_name: '',
        last_name: '',
        email: '',
        phone: '',
        gender: '',
        address: '',
        department: '',
        password: '',
        about: '',
    })


    useEffect(() => {
        if (id !== 0) {
            fetch('http://localhost:5221/api/v1/employee/' + id)
                .then((res) => res.json())
                .then((data) => {
                    console.log(data)
                    setEmployee(data);
                })
        }
    }, [])

    const onChangeInput = (e) => {
        const { id, value } = e.target

        setEmployee({ ...employee, [id]: value })
    }

    const onChangeRadioInput = (e) => {
        const { value } = e.target
        setEmployee({ ...employee, gender: value })
    }

    const onSubmitHandler = () => {
        console.log(employee)


    }
    return (
        <section>

            <h1 className='display-4 mb-5'>Gestão de Funcionário</h1>
            <form>
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
                            value={employee.email}
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
                            <input
                                onChange={onChangeRadioInput}
                                checked={employee.gender == 'Masculino'}
                                className='form-check-input' value='Masculino' type='radio' name='genero' />
                            <label className='form-check-label' htmlFor='Masculino'>
                                Masculino
                            </label>
                        </div>
                        <div className='form-check form-check-inline'>
                            <input
                                onChange={onChangeRadioInput}
                                checked={employee.gender == 'Feminino'}
                                className='form-check-input' value='Feminino' type='radio' name='genero' />
                            <label className='form-check-label' htmlFor='Feminino'>
                                Feminino
                            </label>
                        </div>
                        <div className='form-check form-check-inline'>
                            <input
                                onChange={onChangeRadioInput}
                                checked={employee.gender == 'Não Binário'}
                                className='form-check-input' value='Não Binário' type='radio' name='genero' />
                            <label className='form-check-label' htmlFor='Não Binário'>
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

                <div className="d-flex justify-content-end gap-1">
                    <Button variant='danger' onClick={close}>
                        Cancelar
                    </Button>
                    <Button variant='primary' onClick={onSubmitHandler}>
                        Salvar
                    </Button>
                </div>
            </form>
        </section>
    )
}