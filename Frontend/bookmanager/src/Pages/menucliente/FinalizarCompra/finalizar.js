import React from'react';
import './finalizar.css';
import {Link} from 'react-router-dom';

import codigo from'./codigo.png'

function FinalizarCompra(props){
    
    const infolivro = props.location.state.livro.infolivro;
    const infocliente = props.location.state.cliente.infocliente;
    
    return(
        <div className='nome'>
             <div className="titulofinalizar">
                <div className='drag'>
                    <h1>Parabéns!Compra concluída!</h1>
                </div>
             </div>  
                <div className='jg'>
                    <h3>Você deseja baixar o livro ?</h3>
                </div>
                <div className='codigo'>
                    <img src={codigo}/>
                </div>
            <div className='escolha'>
                <div className="sim">
                    <a className="btn btn-danger" href={"http://3.82.146.171:5000/Funcoescliente/buscarimagem/" + infolivro.nomearquivo}>Sim</a>
                </div>
                <div className="não">
                    <Link className="btn btn-dark" to={{
                        pathname:"/menucliente",
                        state:infocliente
                    }}>Não</Link>
                </div>
            </div>
        </div>
)
}


export default FinalizarCompra;
