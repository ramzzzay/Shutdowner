var Addr = React.createClass({
    render: function() {
        return (
            <address>
    Беларусь
    <br/>
    Брест, совок
    <br/>
    <abbr title="Телефон">T:</abbr>
    425.555.0100
</address>
        );
    }
});

var Mails = React.createClass({
    render: function() {
        return (
            <address>
    <strong>Саппорт:</strong> <a href="mailto:Support@example.com">Support@example.com</a><br/>
    <strong>Вопросы:</strong> <a href="mailto:Marketing@example.com">Questions@example.com</a>
</address>
        );
    }
});

var ar = [
    { Author: "Daniel Lo Nigro", Text: "Hello ReactJS.NET World!" },
    { Author: "Pete Hunt", Text: "This is one comment" },
    { Author: "Jordan Walke", Text: "This is *another* comment" }
];


var Content = React.createClass({
    loadHumansFromServer: function() {
        fetch(this.props.url,
            {
                method: "GET",
                headers: new Headers({
                    "Content-Type": "application/json"
                })
            })
            .then(r => r.json())
            .then(users => this.setState({ data: users }));
    },
    getInitialState: function() {
        return { data: [] };
    },
    componentDidMount: function() {
        this.loadHumansFromServer();
    },
    render: function() {
        return (
            <div>
                <Addr/>
                    <Mails/>
                        {this.state.data.map(u => {
                            return (
                                <div>
                                    <h1>{u.Name}</h1>
                                    <h1>{u.BorneDate}</h1>
                                </div>);})}

            </div>
        );
    }
});


React.render(<Content url="/api/HomeApi/GetHumans"/>, document.getElementById("content"));