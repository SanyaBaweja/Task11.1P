class CounterClass:
    def __init__(c, names):
        c._counts = 0
        c._names = names

    @property
    def getname(c):
        return c._names

    @property
    def setname(c, values):
        c._names = values

    @property
    def counterticks(c):
        return c._counts

    def incrementtick(c):
        c._counts += 1

    def resettick(c):
        c._counts = 0




class ClockClass:
    def __init__(c):
        c._sec = CounterClass("sec")
        c._min = CounterClass("min")
        c._hrs = CounterClass("hrs")

    def increment_the_clock(c):
        c._sec.incrementtick()
        if c._sec.counterticks == 60:
            c._sec.resettick()
            c._min.incrementtick()

            if c._min.counterticks == 60:
                c._min.resettick()
                c._hrs.incrementtick()

                if c._hrs.counterticks == 24:
                    c._hrs.resettick()

    def show(c):
        return f"{c._hrs.counterticks:02d} : {c._min.counterticks:02d} : {c._sec.counterticks:02d}"

if __name__ == "__main__":
    newClock = ClockClass()

    i = 0
    while i<86400:
        i+=1


        newClock.increment_the_clock()
        print(newClock.show())
