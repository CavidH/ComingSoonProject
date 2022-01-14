 
// let comingDate = 'Feb 29, 2022 ')
let Deadline = document.querySelector("#timer").getAttribute('data-deadline')
// console.log(Deadline)
let comingDate = new Date(Deadline)



let d = document.getElementById('days')
let h = document.getElementById('hours')
let m = document.getElementById('minutes')
let s = document.getElementById('seconds')

let x = setInterval(function () {
    let now = new Date()
    let selisih = comingDate.getTime() - now.getTime()

    let days = Math.floor(selisih / (1000 * 60 * 60 * 24))
    let hours = Math.floor(selisih % (1000 * 60 * 60 * 24) / (1000 * 60 * 60))
    let minutes = Math.floor(selisih % (1000 * 60 * 60) / (1000 * 60))
    let seconds = Math.floor(selisih % (1000 * 60) / 1000)

    d.innerHTML = getTrueNumber(days)
    h.innerHTML = getTrueNumber(hours)
    m.innerHTML = getTrueNumber(minutes)
    s.innerHTML = getTrueNumber(seconds)

    if (selisih < 0) {
        clearInterval(x)
        d.innerHTML = '00'
        h.innerHTML = '00'
        m.innerHTML = '00'
        s.innerHTML = '00'
    }
}, 1000)

function getTrueNumber(x) {
    if (x < 10) return '0' + x
    else return x
}