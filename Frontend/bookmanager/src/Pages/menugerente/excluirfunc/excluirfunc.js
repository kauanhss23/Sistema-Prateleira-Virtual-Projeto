import React from 'react'
import {Link} from 'react-router-dom'
import './excluirfunc.css'

import funcoes from '../../Services/FuncoesGerente'
import { ToastContainer, toast} from "react-toastify";
import 'react-toastify/dist/ReactToastify.css';

function ExcluirFunc(props){

    const Idlogin = props.location.state.infofunc.item.idlogin;
    const api = new funcoes();

    const ExcluirFuncionario = async() =>{
        await api.ExcluirRegFuncionarios(Idlogin);
        toast.success("Funcionario Removido do Sistema!");
    }

    return(
       <div className="containerexcluirfunc"> 
        <div className="divprincipaef">
            <div className="tituloexcluirfunc">
                <h1>ATENÇÃO!</h1>
            </div>

            <div className="avisoexcluirfunc">
                <h5>Tem certeza que desja Demitir o funcionário do sistema?</h5>
            </div>

            <div className="botoesexcluirfunc">
                <div className="btn btn-danger" onClick={ExcluirFuncionario}>Demiti-lo</div>
                <Link to="/gergerenfunc" className="btn btn-dark">Não</Link>
            </div>
        </div>
        <ToastContainer />
     </div>
    )
}

export default ExcluirFunc;