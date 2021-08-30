import React from 'react'
import { BrowserRouter, Switch, Route } from 'react-router-dom'

//Base
import Home from './Pages/Home/Home'
import CriarConta from './Pages/CriarConta/App'
import termos from './Pages/CriarConta/index'
import menucliente from './Pages/menucliente/menucliente'
import menugerente from './Pages/menugerente/menugerente'
import menufuncionario from './Pages/menufuncionario/menufuncionario'

//Gerente
import gercadfunc from './Pages/menugerente/gercadfunc/gercadfunc'
import gergerenfunc from './Pages/menugerente/gergerenfunc/gergerenfunc'
import excluirfunc from './Pages/menugerente/excluirfunc/excluirfunc'
import GerenciarFinancas from'./Pages/menugerente/GerenciarFinancas/gerenfinancas'
import VerinfoFunc from './Pages/menugerente/InfoFuncionarios/index'

//Funcionario
import alterlivfunc from './Pages/menufuncionario/alterlivfunc/alterlivfunc'
import conlivfunc from './Pages/menufuncionario/conlivfunc/conlivfunc'
import InserirLivro from './Pages/menufuncionario/TelaInserirLivro/livros'

//Cliente
import MeuPerfil from'./Pages/menucliente/MeuPerfil/Perfil'
import HistoricoCompras from'./Pages/menucliente/HistoricoCompras/HistCompras'
import FazerCompra from './Pages/menucliente/FazerCompra/fazerCompra'
import Compra from'./Pages/menucliente/Compra/compra'
import FinalizarCompra from'./Pages/menucliente/FinalizarCompra/finalizar'

//relatórios
import vendaspormes from './Pages/menugerente/relatórios/vendaspormes/vendaspormes'
import vendaspordia from './Pages/menugerente/relatórios/vendaspordia/vendaspordia'
import topprodutos from './Pages/menugerente/relatórios/topprodutos/topprodutos'
import topclientes from './Pages/menugerente/relatórios/topclientes/topclientes'
import grafico from './Pages/menugerente/relatórios/grafico/grafico'

export default function Routes(){

    return(
        <BrowserRouter>
            <Switch>
                <Route path="/" exact={true} component={Home} />
                <Route path="/criarconta" component={CriarConta} />
                <Route path="/termosEcondicoes" component={termos} />
                <Route path="/menucliente" component={menucliente} />
                <Route path="/menugerente" component={menugerente} />
                <Route path="/menufuncionario" component={menufuncionario} />
                <Route path="/gercadfunc" component={gercadfunc} />
                <Route path="/gergerenfunc" component={gergerenfunc} />
                <Route path="/alterlivfunc" component={alterlivfunc} />
                <Route path="/conlivfunc" component={conlivfunc} />
                <Route path="/gerenciarfinancas" component={GerenciarFinancas}/>
                <Route path="/Perfil" component={MeuPerfil}/>
                <Route path="/HistCompras" component={HistoricoCompras}/>
                <Route path="/FazerCompra" component={FazerCompra} />
                <Route path="/Compra" component={Compra}/>
                <Route path="/finalizar" component={FinalizarCompra}/>
                <Route path="/inserirlivro" component={InserirLivro}/>
                <Route path="/excluirfunc" component={excluirfunc}/>
                <Route path="/vendaspormes" component={vendaspormes}/>
                <Route path="/vendaspordia" component={vendaspordia}/>
                <Route path="/topprodutos" component={topprodutos}/>
                <Route path="/topclientes" component={topclientes}/>
                <Route path="/grafico" component={grafico}/>
                <Route path="/informacoesfuncionario" component={VerinfoFunc}/>
            </Switch>
        </BrowserRouter>
    )
}